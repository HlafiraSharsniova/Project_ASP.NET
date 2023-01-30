
using Project_ASP.NET.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ASP.NET.Models
{
    public class NewReservationVM
    {
        public int Id { get; set; }
        [Display(Name = "Reservation Name")]
        [Required(ErrorMessage = "Name is required")]
        public string NameOfReservation { get; set; }
        [Display(Name = "Description ")]
        [Required(ErrorMessage = "Description is required")]
        public string DescriptionOfReservation { get; set; }
        [Display(Name = "Picture ")]
        [Required(ErrorMessage = "Picture is required")]
        public string imgOfReservation { get; set; }
        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double priceOfReservation { get; set; }

        [Display(Name = "Reservation Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime DateOfReservation { get; set; }
        [Display(Name = "Reservation Time")]
        [Required(ErrorMessage = "Time is required")]
        public DateTime TimeOfReservation { get; set; }
        //public int categoryID { get; set; } //руки или ноги,это и будет категория,к которой будут относиться процедуры
        //public ProcedureCategory ProcedureCategory { get; set; }


        //Relationship
        [Display(Name = "Select category of procedure(s)")]
        [Required(ErrorMessage = "Procedure category is required")]
        public ProcedureCategory ProcedureCategory { get; set; }
        [Display(Name = "Select procedure(s)")]
        [Required(ErrorMessage = "Procedure is required")]
        public List<int> ProcedureIds { get; set; }
        [Display(Name = "Select Master")]
        [Required(ErrorMessage = "Master is required")]
        public int MasterID { get; set; }
        [Display(Name = "Select Client")]
        [Required(ErrorMessage = "Client is required")]
        public int ClientID { get; set; }
    }   
}
