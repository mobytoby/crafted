using AutoMapper;
using Crafted.Data;
using Crafted.DTO;

namespace Crafted.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegistrationDto, AppUser>().ForMember(appUser => appUser.UserName, map => map.MapFrom(dto => dto.Email));
        }
    }
}
