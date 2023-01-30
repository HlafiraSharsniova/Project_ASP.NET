using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Data.ViewModels;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public class ReservationsService : IReservationsService
    {
        private readonly AppDbContext _context;

        public ReservationsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddNewReservationAsync(NewReservationVM data)
        {
            var newReservation = new Reservation()
            {
                NameOfReservation = data.NameOfReservation,
                DateOfReservation = data.DateOfReservation,
                TimeOfReservation = data.TimeOfReservation,
                priceOfReservation = data.priceOfReservation,
                imgOfReservation = data.imgOfReservation,
                DescriptionOfReservation = data.DescriptionOfReservation,
                ClientID = data.ClientID,
                MasterID = data.MasterID,
                ProcedureCategory = data.ProcedureCategory
            };
            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();

            //Add Reservation Procedures
            foreach (var procedurId in data.ProcedureIds)
            {
                var newProcedurereservation = new Procedure_Reservation()
                {
                    ReservationID = newReservation.ReservationId,
                    ProcedureID = procedurId,
                };
                await _context.Procedures_Reservations.AddAsync(newProcedurereservation);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            var result = await _context.Reservations.ToListAsync();
            return result;
        }

        public async Task<NewReservationDropdownsVM> GetNewReservationDropdownsValues()
        {
           var response = new NewReservationDropdownsVM();
            response.Procedures = await _context.Procedures.OrderBy(n => n.Name).ToListAsync();
            response.Clients = await _context.Clients.OrderBy(n => n.Name).ToListAsync();
            response.Masters = await _context.Masters.OrderBy(n => n.Name).ToListAsync();
            return response;
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            var reservationDetails = await _context.Reservations

                .Include(m => m.Master)
                .Include(c => c.Client)
                .Include(pr => pr.Procedures_Reservations).ThenInclude(p => p.Procedure)
                .FirstOrDefaultAsync(n => n.ReservationId == id);
            return reservationDetails;
        }

        public async Task UpdateReservationAsync(NewReservationVM data)
        {
            var dbReservation = await _context.Reservations.FirstOrDefaultAsync(n => n.ReservationId == data.Id);
            if(dbReservation != null)
            {
                dbReservation.NameOfReservation = data.NameOfReservation;
                dbReservation.DateOfReservation = data.DateOfReservation;
                dbReservation.TimeOfReservation = data.TimeOfReservation;
                dbReservation.priceOfReservation = data.priceOfReservation;
                dbReservation.imgOfReservation = data.imgOfReservation;
                dbReservation.DescriptionOfReservation = data.DescriptionOfReservation;
                dbReservation.ClientID = data.ClientID;
                dbReservation.MasterID = data.MasterID;
                dbReservation.ProcedureCategory = data.ProcedureCategory;
                await _context.SaveChangesAsync();
            }
            // Remove existing procedures
            var existingProcedureDb = _context.Procedures_Reservations.Where(n => n.ReservationID == data.Id).ToList();
            _context.Procedures_Reservations.RemoveRange(existingProcedureDb);
            await _context.SaveChangesAsync();

            //Add Reservation Procedures
            foreach (var procedurId in data.ProcedureIds)
            {
                var newProcedureReservation = new Procedure_Reservation()
                {
                    ReservationID = data.Id,
                    ProcedureID = procedurId,
                };
                await _context.Procedures_Reservations.AddAsync(newProcedureReservation);
            }
            await _context.SaveChangesAsync();
        }
        //public async Task AddAsync(Reservation reservation)
        //{
        //    await _context.Reservations.AddAsync(reservation);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Reservations.FirstOrDefaultAsync(n => n.ReservationId == id);
        //    _context.Reservations.Remove(result);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Reservation>> GetAllAsync()
        //{
        //    var result = await _context.Reservations.ToListAsync();
        //    return result;
        //}

        //public async Task<Reservation> GetByIdAsync(int id)
        //{
        //    var result = await _context.Reservations.FirstOrDefaultAsync(n => n.ReservationId == id);
        //    return result;
        //}


        //public async Task<Reservation> UpdateAsync(int id, Reservation newReservation)
        //{
        //    _context.Update(newReservation);
        //    await _context.SaveChangesAsync();
        //    return newReservation;
        //}
    }
}
