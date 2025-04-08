using DAO.Interface;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models;
using System.Data.SQLite;

namespace DAO;

public class DespesaRepository : IDespesaRepository
{
    private readonly string _connectionString;

    public DespesaRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task Post(Despesa despesa)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Despesa>(despesa);
    }

    public async Task<List<Despesa>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var despesas = await connection.GetAllAsync<Despesa>();
        return despesas.ToList();
    }

    public async Task<Despesa> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Despesa>(id);
    }

    public async Task Put(Despesa editDespesa)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Despesa>(editDespesa);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Despesa despesaToRemove = GetById(id).Result;

        await connection.DeleteAsync<Despesa>(despesaToRemove);
    }
}