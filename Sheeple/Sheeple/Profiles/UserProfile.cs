using AutoMapper;
using sheeple.Data.Authentication;
using sheeple.Shared.DTO.Auth;

namespace sheeple.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegistrationDto, ApplicationUser>();
        }
    }
}
