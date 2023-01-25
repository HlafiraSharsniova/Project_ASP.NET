
using System.ComponentModel.DataAnnotations;

namespace Project_ASP.NET.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //Relationships
        public List<Reservation> Reservations { get; set; }
    }
}
