
using System.ComponentModel.DataAnnotations;

namespace Project_ASP.NET.Models
{
    public class Master
    {
        [Key]
        public int MasterId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        //Relationships
        public List<Reservation> Reservations { get; set; }

    }
}
