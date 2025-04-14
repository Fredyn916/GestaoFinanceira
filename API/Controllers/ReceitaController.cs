using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Interface;
using Models.DTO.FinancaDTO;
using Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReceitaController : ControllerBase
{
    private readonly IReceitaService _receitaService;
    private readonly IMapper _mapper;

    public ReceitaController(IReceitaService receitaService, IMapper mapper)
    {
        _receitaService = receitaService;
        _mapper = mapper;
    }

    [HttpPost("PostReceita")]
    public async Task Post(CreateFinancaDTO receitaDTO)
    {
        try
        {
            Receita receita = _mapper.Map<Receita>(receitaDTO);

            await _receitaService.Post(receita);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetReceita")]
    public async Task<List<ResponseFinancaDTO>> Get()
    {
        try
        {
            return await _receitaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdReceita")]
    public async Task<ResponseFinancaDTO> GetById(int id)
    {
        try
        {
            return await _receitaService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutReceita")]
    public async Task<IActionResult> Put(Receita receita)
    {
        try
        {
            await _receitaService.Put(receita);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteReceita")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _receitaService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetByUsuarioIdReceita")]
    public async Task<List<ResponseFinancaDTO>> GetByUsuarioId(int id)
    {
        try
        {
            return await _receitaService.GetByUsuarioId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}