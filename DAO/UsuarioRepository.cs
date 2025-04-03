using DAO.Interface;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models;
using System.Data.SQLite;

namespace DAO;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly string _connectionString;

    public UsuarioRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task<Usuario> Post(Usuario usuario)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Usuario>(usuario);
        return usuario;
    }

    public async Task<List<Usuario>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var clientes = await connection.GetAllAsync<Usuario>();
        return clientes.ToList();
    }

    public async Task<Usuario> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Usuario>(id);
    }

    public async Task Put(Usuario editUsuario)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Usuario>(editUsuario);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Usuario usuarioToRemove = GetById(id).Result;

        await connection.DeleteAsync<Usuario>(usuarioToRemove);
    }

    public async Task<Usuario> Login(String email, String password)
    {
        var users = await Get();

        foreach (Usuario user in users)
        {
            if (user.Email == email && user.Password == password) return user;
        }

        return null;
    }
}