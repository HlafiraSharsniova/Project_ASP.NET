using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Data;
using Project_ASP.NET.Data.Services;
using Project_ASP.NET.Data.Static;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ClientsController : Controller
    {
        private readonly IClientsService _service;

        public ClientsController(IClientsService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get : Client /Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Surname,PhoneNumber,Email,Password")] Client client )
        {
            if (!ModelState.IsValid)
            {
                return View(client);
            }
            await _service.AddAsync(client);
            return RedirectToAction(nameof(Index));
        }
        //Get: Clients /Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var clientDetails = await _service.GetByIdAsync(id);
            if (clientDetails == null) return View("NotFound");
            return View(clientDetails);
        }
        //Get: Clients /Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var clientDetails = await _service.GetByIdAsync(id);
            if (clientDetails == null) return View("NotFound");
            return View(clientDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ClientId,Name,Surname,PhoneNumber,Email,Password")] Client client)
        {
            if (!ModelState.IsValid)
            {
                return View(client);
            }
            await _service.UpdateAsync(id, client);
            return RedirectToAction(nameof(Index));
        }
        //Get: Clients/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var clientDetails = await _service.GetByIdAsync(id);
            if (clientDetails == null) return View("NotFound");
            return View(clientDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientDetails = await _service.GetByIdAsync(id);
            if (clientDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
