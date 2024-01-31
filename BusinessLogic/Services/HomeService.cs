using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Model.Data;
using DataAccess.Model.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class HomeService : IHomeService
    {
        private readonly IMapper mapper;
        private readonly ShopDbContext context;

        public HomeService(IMapper mapper, ShopDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public IEnumerable<ProductDto> GetAllProducts()
        {
            return mapper.Map<List<ProductDto>>(context.Products.Include(x => x.Category).ToList());
        }
    }
}
