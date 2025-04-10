using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Interface;
using Models.DTO.FinancaDTO;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DespesaController : ControllerBase
{
    private readonly IDespesaService _despesaService;
    private readonly IMapper _mapper;

    public DespesaController(IDespesaService despesaService, IMapper mapper)
    {
        _despesaService = despesaService;
        _mapper = mapper;
    }

    [HttpPost("PostDespesa")]
    public async Task Post(CreateFinancaDTO despesaDTO)
    {
        try
        {
            Despesa despesa = _mapper.Map<Despesa>(despesaDTO);

            await _despesaService.Post(despesa);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetDespesa")]
    public async Task<List<ResponseFinancaDTO>> Get()
    {
        try
        {
            return await _despesaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdDespesa")]
    public async Task<ResponseFinancaDTO> GetById(int id)
    {
        try
        {
            return await _despesaService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutDespesa")]
    public async Task<IActionResult> Put(Despesa despesa)
    {
        try
        {
            await _despesaService.Put(despesa);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteDespesa")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _despesaService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}