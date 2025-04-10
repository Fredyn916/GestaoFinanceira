using DAO.Interface;
using Models;
using Models.DTO.FinancaDTO;
using Services.Interface;

namespace Services;

public class ReceitaService : IReceitaService
{
    private readonly IReceitaRepository _receitaRepository;

    public ReceitaService(IReceitaRepository receitaRepository)
    {
        _receitaRepository = receitaRepository;
    }

    public async Task Post(Receita receita)
    {
        await _receitaRepository.Post(receita);
    }

    public async Task<List<ResponseFinancaDTO>> Get()
    {
        return await _receitaRepository.Get();
    }

    public async Task<ResponseFinancaDTO> GetById(int id)
    {
        return await _receitaRepository.GetById(id);
    }

    public async Task Put(Receita receita)
    {
        await _receitaRepository.Put(receita);
    }

    public async Task Delete(int id)
    {
        await _receitaRepository.Delete(id);
    }
}