using DAO.Interface;
using Models;
using Models.DTO.FinancaDTO;
using Services.Interface;

namespace Services;

public class DespesaService : IDespesaService
{
    private readonly IDespesaRepository _despesaRepository;

    public DespesaService(IDespesaRepository despesaRepository)
    {
        _despesaRepository = despesaRepository;
    }

    public async Task Post(Despesa despesa)
    {
        despesa.InverterValor();
        await _despesaRepository.Post(despesa);
    }

    public async Task<List<ResponseFinancaDTO>> Get()
    {
        return await _despesaRepository.Get();
    }

    public async Task<ResponseFinancaDTO?> GetById(int id)
    {
        return await _despesaRepository.GetById(id);
    }

    public async Task Put(Despesa despesa)
    {
        await _despesaRepository.Put(despesa);
    }

    public async Task Delete(int id)
    {
        await _despesaRepository.Delete(id);
    }
}