using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Dtos;
using UserManagement.Entity;

namespace MapperConfig
{
    public static class Mapping
    {
        public static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }

    /// <summary>
    /// map profile from entity to dto or the other way around
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<ApplicationRole, RoleDto>();
            CreateMap<ApplicationPermission, PermissionDto>();
        }
    }
}
