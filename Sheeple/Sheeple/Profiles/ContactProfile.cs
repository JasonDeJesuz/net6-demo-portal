using AutoMapper;
using sheeple.Data.Data.Models;
using sheeple.Shared.DTO.Contact;

namespace sheeple.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();
        }
    }
}