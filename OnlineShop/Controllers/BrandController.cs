using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services.Abstractions;

namespace OnlineShop.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var list = _brandService.GetAll();
            return View(list);
        }
    }
}
