using Project_ASP.NET.Models;

namespace Project_ASP.NET.Models
{
    public class Procedure_Reservation
{
    public int ProcedureID { get; set; }
    public Procedure Procedure { get; set; }
    public int ReservationID { get; set; }
    public Reservation Reservation { get; set; }
}
}
