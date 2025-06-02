using AutoMapper;
using WebApiTemplate.DTOs;
using WebApiTemplate.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiTemplate.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Product mappings
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // User mappings
            CreateMap<ApplicationUser, UserDto>()
                .ForMember(dest => dest.Roles, opt => opt.Ignore());
        }
    }
}