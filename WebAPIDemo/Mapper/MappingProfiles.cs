using AutoMapper;
using WebAPIDemo.Dto;
using WebAPIDemo.Models;

namespace WebAPIDemo.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
        }
    }
}
