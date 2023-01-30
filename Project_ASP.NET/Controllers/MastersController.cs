using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Data;
using Project_ASP.NET.Data.Services;

namespace Project_ASP.NET.Controllers
{
    public class MastersController : Controller
    {

        private readonly AppDbContext _context;

        public MastersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allClients = await _context.Masters.ToListAsync();
            return View(allClients);
        }
    }
}