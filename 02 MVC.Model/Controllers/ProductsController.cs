using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Model.Data;
using DataAccess.Model.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Model.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productService;
        private readonly IMapper mapper;

        public ProductsController(IProductsService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }
		private void LoadCategories()
		{
            var categories = productService.GetAllCategories();
            ViewBag.Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name));
		}
        public IActionResult Index()
        {
            return View(productService.GetAll());
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


            productService.Create(model);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id, string? returnUrl)
		{
            var product = productService.Get(id);
			if (product == null) return NotFound();
            ViewBag.ReturnUrl = returnUrl;
            return View(product);
		}

        public IActionResult Edit(int id)
        {
            var product = productService.Get(id);
            if (product == null) return NotFound();
            LoadCategories();
            return View(mapper.Map<ProductDto>(product));
        }

        [HttpPost]
        public IActionResult Edit(ProductDto model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            productService.Edit(model);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
		{
            productService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
