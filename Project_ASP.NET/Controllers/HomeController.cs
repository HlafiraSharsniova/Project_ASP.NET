using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET.Models;
using System.Diagnostics;

namespace Project_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()//метод для контроллера ХОУМ,переход на главную страницу
        {
            return View();
        }


        public IActionResult Privacy()//переход в прайваси 

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