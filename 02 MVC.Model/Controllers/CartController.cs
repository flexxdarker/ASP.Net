using _02_MVC.Model.Helper;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _02_MVC.Model.Controllers
{
	public class CartController : Controller
	{
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        public IActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(cartService.GetProducts());
        }

        public IActionResult Add(int id, string returnUrl)
        {
            cartService.Add(id);

            //ViewBag.ToastMessage = "Product added to your cart successfully!";
            TempData["ToastMessage"] = "Product added to your cart successfully!";

            return Redirect(returnUrl);
        }

        public IActionResult Remove(int id, string returnUrl)
        {
            cartService.Delete(id);
            TempData["ToastMessage"] = "Product removed from your cart successfully!";

            return Redirect(returnUrl);
        }
    }
}
