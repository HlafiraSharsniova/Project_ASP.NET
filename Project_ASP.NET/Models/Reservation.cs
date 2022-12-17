using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Project_ASP.NET.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int id { get; set; }
        [Required]
        public string NewReservation { get; set; }

        public string PreviousReservation { get; set; }

        public virtual  Procedure Procedure { get; set; }    

    }
}


//