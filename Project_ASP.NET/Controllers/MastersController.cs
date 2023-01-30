using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Data;
using Project_ASP.NET.Data.Services;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Controllers
{
    public class MastersController : Controller
    {

        private readonly IMastersService _service;

        public MastersController(IMastersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get : Master/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Bio")] Master master)
        {
            if (!ModelState.IsValid) return View(master);
            //{
            //    return View(master);
            //}
            await _service.AddAsync(master);
            return RedirectToAction(nameof(Index));
        }
        //Get: Master /Details/1
        public async Task<IActionResult> Details(int id)
        {
            var masterDetails = await _service.GetByIdAsync(id);
            if (masterDetails == null) return View("NotFound");
            return View(masterDetails);
        }
        //Get: Master /Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var masterDetails = await _service.GetByIdAsync(id);
            if (masterDetails == null) return View("NotFound");
            return View(masterDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("MasterId,Name,Bio")] Master master)
        {
            if (!ModelState.IsValid)
            {
                return View(master);
            }
            await _service.UpdateAsync(id, master);
            return RedirectToAction(nameof(Index));
        }
        //Get: Master /Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var masterDetails = await _service.GetByIdAsync(id);
            if (masterDetails == null) return View("NotFound");
            return View(masterDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var masterDetails = await _service.GetByIdAsync(id);
            if (masterDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}