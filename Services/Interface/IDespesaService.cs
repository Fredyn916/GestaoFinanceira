using Models;

namespace Services.Interface;

public interface IDespesaService
{
    Task Post(Despesa despesa);
    Task<List<Despesa>> Get();
    Task<Despesa> GetById(int id);
    Task Put(Despesa editDespesa);
    Task Delete(int id);
}