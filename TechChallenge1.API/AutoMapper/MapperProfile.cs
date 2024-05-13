using AutoMapper;
using TechChallenge1.Core.DTO;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.API.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
                
            CreateMap<State, StateDto>().ReverseMap();
        }
    }
}
