using AutoMapper;
using sheeple.Data.Data.Models;
using sheeple.Shared.DTO.Address;

namespace sheeple.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDTO>();
            CreateMap<AddressDTO, Address>();
        }
    }
}