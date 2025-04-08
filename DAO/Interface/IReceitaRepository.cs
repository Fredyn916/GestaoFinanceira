using Models;

namespace DAO.Interface;

public interface IReceitaRepository
{
    Task Post(Receita receita);
    Task<List<Receita>> Get();
    Task<Receita> GetById(int id);
    Task Put(Receita editReceita);
    Task Delete(int id);
}