
using System.ComponentModel.DataAnnotations;

namespace Project_ASP.NET.Models
{
    public class Master
    {
        [Key]
        public int MasterId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //Relationships
        public List<Reservation> Reservations { get; set; }

    }
}
