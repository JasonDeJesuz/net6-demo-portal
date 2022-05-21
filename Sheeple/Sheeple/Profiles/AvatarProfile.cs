using AutoMapper;
using sheeple.Data.Data.Models;
using sheeple.Shared.DTO.Avatar;

namespace sheeple.Profiles
{
    public class AvatarProfile : Profile
    {
        public AvatarProfile()
        {
            CreateMap<Avatar, AvatarDTO>();
            CreateMap<AvatarDTO, Avatar>();
        }
    }
}