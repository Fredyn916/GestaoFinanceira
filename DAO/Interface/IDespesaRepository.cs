using Models;

namespace DAO.Interface;

public interface IDespesaRepository
{
    Task Post(Despesa despesa);
    Task<List<Despesa>> Get();
    Task<Despesa> GetById(int id);
    Task Put(Despesa editDespesa);
    Task Delete(int id);
}