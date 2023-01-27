using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET.Data;

namespace Project_ASP.NET.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly AppDbContext _context;

        public ProceduresController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Procedures.ToList();
            return View(data);
        }
    }
}
