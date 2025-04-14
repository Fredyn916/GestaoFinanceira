using Models;
using Models.DTO.FinancaDTO;

namespace Services.Interface;

public interface IReceitaService
{
    Task Post(Receita receita);
    Task<List<ResponseFinancaDTO>> Get();
    Task<ResponseFinancaDTO?> GetById(int id);
    Task Put(Receita receita);
    Task Delete(int id);
    Task<List<ResponseFinancaDTO>> GetByUsuarioId(int id);
}