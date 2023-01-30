
using System.ComponentModel.DataAnnotations;

namespace Project_ASP.NET.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Display(Name = "Phone number,without +48")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        //Relationships
        public List<Reservation> Reservations { get; set; }
    }
}
