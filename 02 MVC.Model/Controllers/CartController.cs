using _02_MVC.Model.Helper;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _02_MVC.Model.Controllers
{
	public class CartController : Controller
	{
		private readonly IProductService productService;
		const string key = "cart_items_key";
		public CartController(IProductService productService)
        {
			this.productService = productService;
		}

        public IActionResult Index()
		{
			var ids = HttpContext.Session.Get<List<int>>(key) ?? new();
			HttpContext.Session.Set(key, ids);
			return View();
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
