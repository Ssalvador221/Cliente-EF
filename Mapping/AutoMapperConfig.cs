using AutoMapper;

namespace Treinar.Mapping;

public static class AutoMapperConfig
{
    public static MapperConfiguration GetMapperConfiguration()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        return config;
    }
    
}