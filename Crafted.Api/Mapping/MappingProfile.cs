﻿using AutoMapper;
using Crafted.Data;
using Crafted.DTO;

namespace Crafted.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Incoming
            CreateMap<RegistrationDto, AppUser>().ForMember(appUser => appUser.UserName, map => map.MapFrom(dto => dto.Email));
            CreateMap<CreatedMenuItemDto, MenuItem>();
            CreateMap<ModificationCategoryDto, ModificationCategory>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CreatedCategoryDto, Category>();

            //Outgoing
            CreateMap<Category, CategoryDto>();
            CreateMap<MenuItem, MenuItemDto>();
            CreateMap<MenuItem, CreatedMenuItemDto>();
            CreateMap<ModificationCategory, ModificationCategoryDto>();
        }
    }
}
