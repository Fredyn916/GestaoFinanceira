using Models;

namespace DAO.Interface;

public interface IUsuarioRepository
{
    Task<Usuario> Post(Usuario usuario);
    Task<List<Usuario>> Get();
    Task<Usuario> GetById(int id);
    Task Put(Usuario editUsuario);
    Task Delete(int id);
    Task<Usuario> Login(String email, String password);
}