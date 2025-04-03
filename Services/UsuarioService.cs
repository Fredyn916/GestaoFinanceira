using DAO.Interface;
using Models;
using Services.Interface;

namespace Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<Usuario> Post(Usuario usuario)
    {
        return await _usuarioRepository.Post(usuario);
    }

    public async Task<List<Usuario>> Get()
    {
        return await _usuarioRepository.Get();
    }

    public async Task<Usuario> GetById(int id)
    {
        return await _usuarioRepository.GetById(id);
    }

    public async Task Put(Usuario editCliente)
    {
        await _usuarioRepository.Put(editCliente);
    }

    public async Task Delete(int id)
    {
        await _usuarioRepository.Delete(id);
    }

    public async Task<Usuario> Login(String email, String password)
    {
        return await _usuarioRepository.Login(email, password);
    }
}