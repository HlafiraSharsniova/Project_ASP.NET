using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var data = await _service.GetAllAsync();
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
            await _service.AddAsync(procedure);
            return RedirectToAction(nameof(Index));
        }
        //Get: Procedures/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var procedureDetails = await _service.GetByIdAsync(id);
            if (procedureDetails == null) return View("NotFound");
            return View(procedureDetails);
        }
        //Get: Procedures/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var procedureDetails = await _service.GetByIdAsync(id);
            if (procedureDetails == null) return View("NotFound");
            return View(procedureDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ProcedureId,Name,Desc,img,price")] Procedure procedure)
        {
            if (!ModelState.IsValid)
            {
                return View(procedure);
            }
            await _service.UpdateAsync(id, procedure);
            return RedirectToAction(nameof(Index));
        }
        //Get: Procedures/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var procedureDetails = await _service.GetByIdAsync(id);
            if (procedureDetails == null) return View("NotFound");
            return View(procedureDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var procedureDetails = await _service.GetByIdAsync(id);
            if (procedureDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
