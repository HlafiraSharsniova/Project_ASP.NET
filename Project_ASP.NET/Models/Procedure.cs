
using System.ComponentModel.DataAnnotations;
using Project_ASP.NET.Data.Enums;

namespace Project_ASP.NET.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }
        [Display(Name = "The name of the procedure")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }
        [Display(Name = "Description of the procedure")]
        [Required(ErrorMessage = "Description is required")]
        public string Desc { get; set; } //короткое описание
        [Display(Name = "Photo of the procedure")]
        [Required(ErrorMessage = "The picture is required")]
        public string img { get; set; }
        [Display(Name = "The price of the procedure")]
        [Required(ErrorMessage = "The price is required")]
        public double price { get; set; } //юшорт потому что цена не может быть с минусом и это не миллион знаков
        //public bool isFavourite { get; set; } //
        //public bool available { get; set; } //если о товарах,то есть ли в наличии на складе и сколько,не знаю,буду ли использовать 

        

        //Relationships
        public List<Procedure_Reservation>? Procedures_Reservations { get; set; }
    }
}