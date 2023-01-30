
using Project_ASP.NET.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ASP.NET.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Display(Name ="Name")]
        public string NameOfReservation { get; set; }
        [Display(Name = "Description of procedure")]
        public string DescriptionOfReservation { get; set; }
        [Display(Name = "Picture of procedure")]
        public string imgOfReservation { get; set; }
        [Display(Name = "Cost of your reservation")]
        public double priceOfReservation { get; set; }

        [Display(Name = "Date")]
        public DateTime DateOfReservation { get; set; }
        [Display(Name = "Time")]
        public DateTime TimeOfReservation { get; set; }
        //public int categoryID { get; set; } //руки или ноги,это и будет категория,к которой будут относиться процедуры
        //public ProcedureCategory ProcedureCategory { get; set; }


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
