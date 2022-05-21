using sheeple.Shared.DTO.Person;
using AutoMapper;
using sheeple.Data.Data.Models;

namespace sheeple.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Person, PersonDTO>()
                .ForMember(
                    dest => dest.Address,
                    opt => opt.MapFrom(src => src.Address)
                )
                .ForMember(
                    dest => dest.Contact,
                    opt => opt.MapFrom(src => src.Contact)
                )
                .ForMember(
                    dest => dest.Avatar,
                    opt => opt.MapFrom(src => src.Avatar)
                ).ReverseMap();
        }
    }
}