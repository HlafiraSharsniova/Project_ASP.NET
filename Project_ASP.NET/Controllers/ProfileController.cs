using Project_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project_ASP.NET.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index() // profile
        {
            return View();
        }
        [HttpPost] //передача данных из какой-либо формочки
        public IActionResult Check(Profile profile) // profile
        {
           if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
