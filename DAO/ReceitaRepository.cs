using DAO.Interface;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models;
using System.Data.SQLite;

namespace DAO;

public class ReceitaRepository : IReceitaRepository
{
    private readonly string _connectionString;

    public ReceitaRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task Post(Receita receita)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Receita>(receita);
    }

    public async Task<List<Receita>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var receitas = await connection.GetAllAsync<Receita>();
        return receitas.ToList();
    }

    public async Task<Receita> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Receita>(id);
    }

    public async Task Put(Receita editReceita)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Receita>(editReceita);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Receita receitaToRemove = GetById(id).Result;

        await connection.DeleteAsync<Receita>(receitaToRemove);
    }
}