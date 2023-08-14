using AutoMapper;
using Treinar.Data.Entidades;
using Treinar.Models;

namespace Treinar.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Cliente, ClienteViewModel>().ReverseMap();
        CreateMap<CepCliente, CepClienteViewModel>().ReverseMap();
    }
    
    
}