using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services.Abstractions;

namespace OnlineShop.Controllers
{
    public class FileTypeController : Controller
    {
        private readonly IFileTypeService _fileTypeService;

        public FileTypeController(IFileTypeService fileTypeService)
        {
            _fileTypeService = fileTypeService;
        }

        public IActionResult Index()
        {
            var list = _fileTypeService.GetAll();
            return View(list);
        }
    }
}
