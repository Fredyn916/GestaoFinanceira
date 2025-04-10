using Models;
using Models.DTO.FinancaDTO;

namespace DAO.Interface;

public interface IReceitaRepository
{
    Task Post(Receita receita);
    Task<List<ResponseFinancaDTO>> Get();
    Task<ResponseFinancaDTO?> GetById(int id);
    Task Put(Receita receita);
    Task Delete(int id);
}