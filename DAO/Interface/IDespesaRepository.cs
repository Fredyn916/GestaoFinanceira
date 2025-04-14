using Models;
using Models.DTO.FinancaDTO;

namespace DAO.Interface;

public interface IDespesaRepository
{
    Task Post(Despesa despesa);
    Task<List<ResponseFinancaDTO>> Get();
    Task<ResponseFinancaDTO?> GetById(int id);
    Task Put(Despesa despesa);
    Task Delete(int id);
    Task<List<ResponseFinancaDTO>> GetByUsuarioId(int id);
}