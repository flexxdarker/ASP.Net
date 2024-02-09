using _02_MVC.Model.Helper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class CartService : ICartService
	{
		const string key = "cart_items_key";
		private readonly IProductsService productsService;
		private readonly HttpContext httpContext;

		public CartService(IProductsService productsService, IHttpContextAccessor contextAccessor)
		{
			this.productsService = productsService;
			httpContext = contextAccessor.HttpContext ?? throw new Exception();
		}

		private List<int> GetCartItems()
		{
			return httpContext.Session.Get<List<int>>(key) ?? new();
		}
		private void SaveCartItems(List<int> items)
		{
			httpContext.Session.Set(key, items);
		}

		public void Add(int id)
		{
			var ids = GetCartItems();
			ids.Add(id);

			SaveCartItems(ids);
		}

		public IEnumerable<ProductDto> GetProducts()
		{
			var ids = GetCartItems();
			return productsService.Get(ids);
		}

		public int GetCount()
		{
			return GetCartItems().Count;
		}

		public void Delete(int id)
		{
			var ids = GetCartItems();
			ids.Remove(id);

			SaveCartItems(ids);
		}

        public IEnumerable<int> GetProducIds()
        {
			return GetCartItems();
        }

		public int Summ()
		{
			return 2;
		}
	}
}
