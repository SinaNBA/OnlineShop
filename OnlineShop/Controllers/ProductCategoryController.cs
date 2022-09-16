using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop.Services.Abstractions;
using System.Linq;

namespace OnlineShop.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            var list = _productCategoryService.GetAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var list = _productCategoryService.GetAll();
            ViewBag.ParentSelectList = list.Select(x => new SelectListItem
            {
                Text = x.Title,
                Value = x.Id.ToString()
            }).ToList();
            return View();
        }

    }
}
