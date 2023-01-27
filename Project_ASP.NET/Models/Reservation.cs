
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ASP.NET.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        public DateTime DateOfReservation { get; set; }
        public DateTime TimeOfReservation { get; set; }

        //Relationship
        public List<Procedure_Reservation> Procedures_Reservations { get; set; }

        //Master
        public int MasterID { get; set; }
        [ForeignKey("MasterID")]
        public Master Master { get; set; }

        //Client
        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public Client Client { get; set; }
    }
}
