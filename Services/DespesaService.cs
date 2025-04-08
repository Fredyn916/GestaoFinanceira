using DAO.Interface;
using Models;
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

    public async Task<List<Despesa>> Get()
    {
        return await _despesaRepository.Get();
    }

    public async Task<Despesa> GetById(int id)
    {
        return await _despesaRepository.GetById(id);
    }

    public async Task Put(Despesa editDespesa)
    {
        await _despesaRepository.Put(editDespesa);
    }

    public async Task Delete(int id)
    {
        await _despesaRepository.Delete(id);
    }
}