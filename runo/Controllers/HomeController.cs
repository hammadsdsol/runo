using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using runo.Models;
using runo.Services;

namespace runo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodoService _todoService;

        public HomeController(ILogger<HomeController> logger , ITodoService todoService)
        {
            _logger = logger;

            _todoService = todoService;

        }

        public async Task<IActionResult> Index()
        {

            var allTodos = await _todoService.GetAllTodosAsync();

            return View(allTodos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
