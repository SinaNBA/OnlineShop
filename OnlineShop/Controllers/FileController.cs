using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services.Abstractions;

namespace OnlineShop.Controllers
{
    public class FileController : Controller
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        public IActionResult Index()
        {
            var list = _fileService.GetAll();
            return View(list);
        }
    }
}
