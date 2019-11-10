using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SportStorage.Models;
using SportStorage.Infrastructure;
using SportStorage.Models.ViewModels;

namespace SportStorage.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly Cart _cartService;

        public CartController( IProductRepository productRepository, Cart cartService)
        {
            _productRepository = productRepository;
            _cartService = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = _cartService,
                ReturnUrl = returnUrl
            });
        }
        
        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = _productRepository.Products
                .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                _cartService.AddItem(product, 1);
            }

            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = _productRepository.Products.FirstOrDefault(m => m.ProductId == productId);
            if (product != null)
            {
                _cartService.RemoveLine(product);
            }

            return RedirectToAction("Index", new {returnUrl});
        }
    }
}