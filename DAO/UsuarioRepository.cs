using AutoMapper;
using DAO.Interface;
using Models;
using Models.DTO.UsuarioDTO;
using Supabase;

namespace DAO;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly Client _client;
    private readonly IMapper _mapper;

    public UsuarioRepository(Client client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    public async Task<ResponseUsuarioDTO> Post(Usuario usuario)
    {
        var response = await _client.From<Usuario>().Insert(usuario);

        ResponseUsuarioDTO user = _mapper.Map<ResponseUsuarioDTO>(response.Models.First());
        return user;
    }

    public async Task<List<ResponseUsuarioDTO>> Get()
    {
        List<ResponseUsuarioDTO> usuarios = new List<ResponseUsuarioDTO>();

        var response = await _client.From<Usuario>().Get();

        foreach (var item in response.Models)
        {
            usuarios.Add(_mapper.Map<ResponseUsuarioDTO>(item));
        }
        return usuarios;
    }

    public async Task<ResponseUsuarioDTO?> GetById(int id)
    {
        var response = await _client.From<Usuario>()
            .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, id)
            .Get();

        ResponseUsuarioDTO usuario = _mapper.Map<ResponseUsuarioDTO>(response.Models.First());
        return usuario;
    }

    public async Task Put(Usuario usuario)
    {
        await _client.From<Usuario>().Update(usuario);
    }

    public async Task Delete(int id)
    {
        var user = _mapper.Map<Usuario>(GetById(id).Result);
        await _client.From<Usuario>().Delete(user);
    }

    public async Task<ResponseUsuarioDTO> Login(String email, String password)
    {
        foreach (var item in Get().Result)
        {
            if (item.Email == email && item.Password == password)
            {
                return item;
            }
        }
        return null;
    }
}