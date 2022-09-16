using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services.Abstractions;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var list = _productService.GetAll();
            return View(list);
        }
    }
}
