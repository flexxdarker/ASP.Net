using _02_MVC.Model.Data;
using _02_MVC.Model.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _02_MVC.Model.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopDbContext context;

        public ProductsController(ShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var products = context.Products.Include(x => x.Category).ToList();

            return View(products);
        }

        public IActionResult Description()
        {
            return View();
        }

        public IActionResult Create()
        {
			ViewBag.Categories = new SelectList(context.Categories, "Name", "Id");

			return View();
        }

        public IActionResult Create(Product model)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			context.Products.Add(model);
			context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var product = context.Products.Find(id);

			if (product == null) return NotFound();

			return View(product);
		}

		public IActionResult Delete(int id)
		{
			var product = context.Products.Find(id);

			if (product == null) return NotFound();

			context.Remove(product);
			context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}
	}
}
