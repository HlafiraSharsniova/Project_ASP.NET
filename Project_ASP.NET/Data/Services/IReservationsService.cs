using Project_ASP.NET.Data.ViewModels;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public interface IReservationsService
    {
        Task<IEnumerable<Reservation>> GetAllAsync();
        //Task<Reservation> GetByIdAsync(int id);
        //Task AddAsync(Reservation reservation);
        //Task<Reservation> UpdateAsync(int id, Reservation newReservation);
        //Task DeleteAsync(int id);
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<NewReservationDropdownsVM> GetNewReservationDropdownsValues();
        Task AddNewReservationAsync(NewReservationVM data);
        Task UpdateReservationAsync(NewReservationVM data);
    }
}
