using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Services.Interface;


namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;
    private readonly IMapper _mapper;

    public UsuarioController(IUsuarioService usuarioService, IMapper mapper)
    {
        _usuarioService = usuarioService;
        _mapper = mapper;
    }

    [HttpPost("PostUsuario")]
    public async Task<Usuario> Post(UsuarioDTO usuarioDTO)
    {
        try
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDTO);

            return await _usuarioService.Post(usuario);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetUsuario")]
    public async Task<List<Usuario>> Get()
    {
        try
        {
            return await _usuarioService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdUsuario")]
    public async Task<Usuario> GetById(int id)
    {
        try
        {
            return await _usuarioService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutUsuario")]
    public async Task<IActionResult> Put(Usuario usuario)
    {
        try
        {
            await _usuarioService.Put(usuario);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteUsuario")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _usuarioService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("LoginUsuario")]
    public async Task<Usuario> Login(String email, String password)
    {
        try
        {
            var user = await _usuarioService.Login(email, password);

            if (user != null) return user;
            else throw new Exception();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}