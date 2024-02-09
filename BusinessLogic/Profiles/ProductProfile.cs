using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Entities;
using DataAccess.Model.Data.Entities;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        { 
            CreateMap<ProductDto, Product>()
                .ForMember(x=>x.Category, opt => opt.Ignore());
            CreateMap<Product, ProductDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Order, OrderDto>();
        }
    }
}
