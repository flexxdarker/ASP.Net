using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using DataAccess.Model.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IMapper mapper;
        private readonly ShopDbContext context;
        private readonly ICartService cartService;

        public OrdersService(IMapper mapper, ShopDbContext context, ICartService cartService)
        {
            this.mapper = mapper;
            this.context = context;
            this.cartService = cartService;
        }

        public void Create(string userId)
        {
            var ids = cartService.GetProducIds();
            var products = context.Products.Where(x => ids.Contains(x.Id)).ToList();

            var order = new Order()
            {
                Date = DateTime.Now,
                UserId = userId,
                Products = products,
                OrderSumm = products.Sum(x => x.Price),
            };

            context.Orders.Add(order);
            context.SaveChanges();
        }

        public IEnumerable<OrderDto> GetAllByUser(string userId)
        {
            var items = context.Orders.Include(x => x.Products).Where(x => x.UserId == userId).ToList();
            return mapper.Map<IEnumerable<OrderDto>>(items);
        }
    }
}
