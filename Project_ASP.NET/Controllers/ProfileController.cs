using Microsoft.AspNetCore.Mvc;

namespace Project_ASP.NET.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
