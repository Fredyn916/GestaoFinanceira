using AutoMapper;
using Models;
using Models.DTO;

namespace Config.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UsuarioDTO, Usuario>().ReverseMap();
        CreateMap<FinancaDTO, Receita>().ReverseMap();
        CreateMap<FinancaDTO, Despesa>().ReverseMap();
    }
}