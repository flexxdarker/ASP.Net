using _02_MVC.Model.Helper;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _02_MVC.Model.Controllers
{
	public class CartController : Controller
	{
		private readonly IProductsService productService;
		const string key = "cart_items_key";
		public CartController(IProductsService productService)
        {
			this.productService = productService;
		}

        public IActionResult Index()
		{
			var ids = HttpContext.Session.Get<List<int>>(key) ?? new();
			return View(productService.Get(ids));
		}

		public IActionResult Add(int id)
		{
			var ids = HttpContext.Session.Get<List<int>>(key) ?? new();
			ids.Add(id);

			HttpContext.Session.SetString(key, JsonSerializer.Serialize(ids));

			return RedirectToAction(nameof(Index));
		}
		public IActionResult Remove(int id)
		{
			// TODO
			return RedirectToAction(nameof(Index));
		}
	}
}
