using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Data;
using Project_ASP.NET.Data.Services;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationsService _service;
        public ReservationsController(IReservationsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allReservations = await _service.GetAllAsync();
            return View(allReservations);
        }
        public async Task<IActionResult> Filter(string searchString)
        {
            var allReservations = await _service.GetAllAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResult = allReservations.Where(n => n.NameOfReservation.Contains(searchString) || n.DescriptionOfReservation.Contains
                (searchString)).ToList();
                return View("Index", filterResult);
            }
            return View("Index", allReservations);
        }

        //Get: Reservations/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var reservationDetails = await _service.GetReservationByIdAsync(id);
            return View(reservationDetails);
        }
        //Get : Reservation /Create
        public async Task<IActionResult> Create()
        {
            var reservationDropdownsData = await _service.GetNewReservationDropdownsValues();

            ViewBag.Procedures = new SelectList(reservationDropdownsData.Procedures, "ProcedureId", "Name");
            ViewBag.Masters= new SelectList(reservationDropdownsData.Masters, "MasterId", "Name");
            ViewBag.Clients = new SelectList(reservationDropdownsData.Clients, "ClientId", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewReservationVM reservation)
        {
            if(!ModelState.IsValid)
            {
                var reservationDropdownsData = await _service.GetNewReservationDropdownsValues();
                ViewBag.Procedures = new SelectList(reservationDropdownsData.Procedures, "ProcedureId", "Name");
                ViewBag.Masters = new SelectList(reservationDropdownsData.Masters, "MasterId", "Name");
                ViewBag.Clients = new SelectList(reservationDropdownsData.Clients, "ClientId", "Name");
                return View(reservation);
            }
            await _service.AddNewReservationAsync(reservation);
            return RedirectToAction(nameof(Index));
        }
        //if (!ModelState.IsValid)
        //{
        //ViewData["Welcome"] = "Welcome to our studio";
        //return View();
        //}
        //await _service.AddAsync(procedure);
        //return RedirectToAction(nameof(Index));
        //}
        ////Get: Procedures/Edit/1
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var procedureDetails = await _service.GetByIdAsync(id);
        //    if (procedureDetails == null) return View("NotFound");
        //    return View(procedureDetails);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, [Bind("ProcedureId,Name,Desc,img,price")] Procedure procedure)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(procedure);
        //    }
        //    await _service.UpdateAsync(id, procedure);
        //    return RedirectToAction(nameof(Index));
        //}
        ////Get: Procedures/Delete/1
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var procedureDetails = await _service.GetByIdAsync(id);
        //    if (procedureDetails == null) return View("NotFound");
        //    return View(procedureDetails);
        //}
        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var procedureDetails = await _service.GetByIdAsync(id);
        //    if (procedureDetails == null) return View("NotFound");

        //    await _service.DeleteAsync(id);
        //    return RedirectToAction(nameof(Index));
        //}
        //Get : Reservation /Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var reservationDetails = await _service.GetReservationByIdAsync(id);
            if (reservationDetails == null) return View("NotFound");

            var response = new NewReservationVM()
            {
                Id = reservationDetails.ReservationId,
                NameOfReservation = reservationDetails.NameOfReservation,
                DateOfReservation = reservationDetails.DateOfReservation,
                TimeOfReservation = reservationDetails.TimeOfReservation,
                priceOfReservation = reservationDetails.priceOfReservation,
                imgOfReservation = reservationDetails.imgOfReservation,
                DescriptionOfReservation = reservationDetails.DescriptionOfReservation,
                ProcedureCategory = reservationDetails.ProcedureCategory,
                MasterID = reservationDetails.MasterID,
                ClientID = reservationDetails.ClientID,
                ProcedureIds = reservationDetails.Procedures_Reservations.Select(n => n.ProcedureID).ToList(),
              
            };

            var reservationDropdownsData = await _service.GetNewReservationDropdownsValues();

            ViewBag.Procedures = new SelectList(reservationDropdownsData.Procedures, "ProcedureId", "Name");
            ViewBag.Masters = new SelectList(reservationDropdownsData.Masters, "MasterId", "Name");
            ViewBag.Clients = new SelectList(reservationDropdownsData.Clients, "ClientId", "Name");
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewReservationVM reservation)
        {
            if (id != reservation.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var reservationDropdownsData = await _service.GetNewReservationDropdownsValues();
                ViewBag.Procedures = new SelectList(reservationDropdownsData.Procedures, "ProcedureId", "Name");
                ViewBag.Masters = new SelectList(reservationDropdownsData.Masters, "MasterId", "Name");
                ViewBag.Clients = new SelectList(reservationDropdownsData.Clients, "ClientId", "Name");
                return View(reservation);
            }
            await _service.UpdateReservationAsync(reservation);
            return RedirectToAction(nameof(Index));
        }
    }

}
