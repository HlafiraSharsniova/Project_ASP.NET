using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET.Data;
using Project_ASP.NET.Data.Services;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly IProceduresService _service;

        public ProceduresController(IProceduresService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        //Get : Procedure/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Desc,img,price")]Procedure procedure)
        {
            if(!ModelState.IsValid)
            {
                return View(procedure);
            }
            _service.Add(procedure);
            return RedirectToAction(nameof(Index));
        }
    }
}
