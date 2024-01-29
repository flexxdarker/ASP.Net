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
		private void LoadCategories()
		{
			ViewBag.Categories = new SelectList(context.Categories.ToList(), nameof(Category.Id), nameof(Category.Name));

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
			LoadCategories();
			return View();
        }

		[HttpPost]
        public IActionResult Create(Product model)
		{
			if (!ModelState.IsValid)
			{
				LoadCategories();
				return View();
			}

			context.Products.Add(model);
			context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id, string? returnUrl)
		{
			var product = context.Products.Find(id);
			context.Entry(product).Reference(x => x.Category).Load();
			if (product == null) return NotFound();
            ViewBag.ReturnUrl = returnUrl;
            return View(product);
		}

        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            LoadCategories();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            context.Products.Update(model);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
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
