using AutoMapper;
using DAO.Interface;
using Models;
using Models.DTO.FinancaDTO;
using Supabase;

namespace DAO;

public class ReceitaRepository : IReceitaRepository
{
    private readonly Client _client;
    private readonly IMapper _mapper;

    public ReceitaRepository(Client client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    public async Task Post(Receita receita)
    {
        var response = await _client.From<Receita>().Insert(receita);
    }

    public async Task<List<ResponseFinancaDTO>> Get()
    {
        List<ResponseFinancaDTO> receitas = new List<ResponseFinancaDTO>();

        var response = await _client.From<Receita>().Get();

        foreach (var item in response.Models)
        {
            receitas.Add(_mapper.Map<ResponseFinancaDTO>(item));
        }
        return receitas;
    }

    public async Task<ResponseFinancaDTO> GetById(int id)
    {
        var response = await _client.From<Receita>()
           .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, id)
           .Get();

        ResponseFinancaDTO receita = _mapper.Map<ResponseFinancaDTO>(response.Models.First());
        return receita;
    }

    public async Task Put(Receita receita)
    {
        await _client.From<Receita>().Update(receita);
    }

    public async Task Delete(int id)
    {
        var receita = _mapper.Map<Receita>(GetById(id).Result);
        await _client.From<Receita>().Delete(receita);
    }

    public async Task<List<ResponseFinancaDTO>> GetByUsuarioId(int id)
    {
        List<ResponseFinancaDTO> receitasResponse = new List<ResponseFinancaDTO>();

        var receitas = await Get();

        foreach (var item in receitas)
        {
            if (item.UsuarioId == id) receitasResponse.Add(item);
        }

        return receitasResponse;
    }
}