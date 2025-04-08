using Models;

namespace Services.Interface;

public interface IReceitaService
{
    Task Post(Receita receita);
    Task<List<Receita>> Get();
    Task<Receita> GetById(int id);
    Task Put(Receita editReceita);
    Task Delete(int id);
}