
using System.ComponentModel.DataAnnotations;

namespace Project_ASP.NET.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }
        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Surname { get; set; }
        [Display(Name = "Phone number,without +48")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(9, ErrorMessage = "Phone number must be 9 chars")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Please enter a correct email address!")]
        
        public string Email { get; set; }
        [Display(Name = "Password")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Please enter a correct password!")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 50 chars")]
        public string Password { get; set; }
        //Relationships
        public List<Reservation> Reservations { get; set; }
    }
}
