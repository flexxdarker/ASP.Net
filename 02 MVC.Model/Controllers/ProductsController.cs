using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Model.Data;
using DataAccess.Model.Data.Entities;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(productService.GetAll());
        }
        [AllowAnonymous]
        public IActionResult Description()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
			LoadCategories();
			return View();
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult Details(int id, string? returnUrl)
		{
            var product = productService.Get(id);
			if (product == null) return NotFound();
            ViewBag.ReturnUrl = returnUrl;
            return View(product);
		}
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var product = productService.Get(id);
            if (product == null) return NotFound();
            LoadCategories();
            return View(mapper.Map<ProductDto>(product));
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
		{
            productService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
