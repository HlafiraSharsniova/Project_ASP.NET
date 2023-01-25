
using System.ComponentModel.DataAnnotations;

namespace Project_ASP.NET.Models
{
    public class Master
    {
        [Key]
        public int MasterID { get; set; }
        public string Name { get; set; }

        public string Bio { get; set; }
        //Relationships
        public List<Reservation> Reservations { get; set; }

    }
}
