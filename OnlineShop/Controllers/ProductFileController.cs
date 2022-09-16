using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services.Abstractions;

namespace OnlineShop.Controllers
{
    public class ProductFileController : Controller
    {
        private readonly IProductFileService _productFileService;

        public ProductFileController(IProductFileService productFileService)
        {
            _productFileService = productFileService;
        }

        public IActionResult Index()
        {
            var list = _productFileService.GetAll();
            return View(list);
        }
    }
}
