using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Model.Data;
using DataAccess.Model.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Model.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopDbContext context;
        private readonly IMapper mapper;

        public ProductsController(ShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
		private void LoadCategories()
		{
            var categories = mapper.Map<List<CategoryDto>>(context.Categories.ToList());
            ViewBag.Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name));
		}
        public IActionResult Index()
        {
            var products = mapper.Map<List<ProductDto>>(context.Products.Include(x=>x.Category).ToList());

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
        public IActionResult Create(ProductDto model)
		{
			if (!ModelState.IsValid)
			{
				LoadCategories();
				return View();
			}

			context.Products.Add(mapper.Map<Product>(model));
			context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id, string? returnUrl)
		{
			var product = context.Products.Find(id);
			context.Entry(product).Reference(x => x.Category).Load();
			if (product == null) return NotFound();
            ViewBag.ReturnUrl = returnUrl;
            var dto = mapper.Map<ProductDto>(product);
            return View(dto);
		}

        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            LoadCategories();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(ProductDto model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            context.Products.Update(mapper.Map<Product>(model));
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
