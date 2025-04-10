using AutoMapper;
using Models;
using Models.DTO.FinancaDTO;
using Models.DTO.UsuarioDTO;

namespace Settings.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUsuarioDTO, Usuario>().ReverseMap();
        CreateMap<ResponseUsuarioDTO, Usuario>().ReverseMap();
        CreateMap<CreateFinancaDTO, Receita>().ReverseMap();
        CreateMap<CreateFinancaDTO, Despesa>().ReverseMap();
        CreateMap<ResponseFinancaDTO, Receita>().ReverseMap();
        CreateMap<ResponseFinancaDTO, Despesa>().ReverseMap();
    }
}