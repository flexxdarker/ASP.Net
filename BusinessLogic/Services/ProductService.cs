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
    public class ProductService : IProductService
    {
        private readonly IMapper mapper;
        private readonly ShopDbContext context;

        public ProductService(IMapper mapper, ShopDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public void Create(ProductDto product)
        {
            context.Products.Add(mapper.Map<Product>(product));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = context.Products.Find(id);
            if (product != null) { return; }
            context.Remove(product);
            context.SaveChanges();
        }

        public void Edit(ProductDto product)
        {
            context.Products.Update(mapper.Map<Product>(product));
            context.SaveChanges();
        }

        public ProductDto? Get(int id)
        {
            var item = context.Products.Find(id);
            if(item == null) { return null; }
            context.Entry(item).Reference(x => x.Category).LoadAsync();
            var dto = mapper.Map<ProductDto>(item);
            return dto;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return mapper.Map<List<ProductDto>>(context.Products.Include(x=>x.Category).ToList());
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return mapper.Map<List<CategoryDto>>(context.Categories.ToList());
        }
    }
}
