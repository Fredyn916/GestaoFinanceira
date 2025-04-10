using AutoMapper;
using DAO.Interface;
using Models;
using Models.DTO.FinancaDTO;
using Supabase;

namespace DAO;

public class DespesaRepository : IDespesaRepository
{
    private readonly Client _client;
    private readonly IMapper _mapper;

    public DespesaRepository(Client client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    public async Task Post(Despesa despesa)
    {
        var response = await _client.From<Despesa>().Insert(despesa);
    }

    public async Task<List<ResponseFinancaDTO>> Get()
    {
        List<ResponseFinancaDTO> despesas = new List<ResponseFinancaDTO>();

        var response = await _client.From<Despesa>().Get();

        foreach (var item in response.Models)
        {
            despesas.Add(_mapper.Map<ResponseFinancaDTO>(item));
        }
        return despesas;
    }

    public async Task<ResponseFinancaDTO?> GetById(int id)
    {
        var response = await _client.From<Despesa>()
            .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, id)
            .Get();

        ResponseFinancaDTO despesa = _mapper.Map<ResponseFinancaDTO>(response.Models.First());
        return despesa;
    }

    public async Task Put(Despesa despesa)
    {
        await _client.From<Despesa>().Update(despesa);
    }

    public async Task Delete(int id)
    {
        var despesa = _mapper.Map<Despesa>(GetById(id).Result);
        await _client.From<Despesa>().Delete(despesa);
    }
}