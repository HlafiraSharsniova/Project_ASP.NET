using Microsoft.AspNetCore.Mvc;

namespace Project_ASP.NET.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index() // reservation
        {
            return View();
        }
    }
}
