using AutoMapper;
using sheeple.Data.Data.Models;
using sheeple.Shared.DTO.Address;
using sheeple.Shared.DTO.Helper;

namespace sheeple.Profiles
{
    public class HelperProfile : Profile
    {
        public HelperProfile()
        {
            CreateMap<DropdownCountry, DropdownCountryDTO>().ReverseMap();

            CreateMap<DropdownGender, DropdownGenderDTO>().ReverseMap();
        }
    }
}