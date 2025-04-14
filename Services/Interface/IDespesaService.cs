using Models;
using Models.DTO.FinancaDTO;

namespace Services.Interface;

public interface IDespesaService
{
    Task Post(Despesa despesa);
    Task<List<ResponseFinancaDTO>> Get();
    Task<ResponseFinancaDTO?> GetById(int id);
    Task Put(Despesa despesa);
    Task Delete(int id);
    Task<List<ResponseFinancaDTO>> GetByUsuarioId(int id);
}