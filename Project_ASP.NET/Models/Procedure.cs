
using System.ComponentModel.DataAnnotations;
using Project_ASP.NET.Data.Enums;

namespace Project_ASP.NET.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }
        [Display(Name = "The name of the procedure")]
        public string Name { get; set; }
        [Display(Name = "Description of the procedure")]
        public string Desc { get; set; } //короткое описание
        [Display(Name = "Photo of the procedure")]

        public string img { get; set; }
        [Display(Name = "The price of the procedure")]
        public double price { get; set; } //юшорт потому что цена не может быть с минусом и это не миллион знаков
        //public bool isFavourite { get; set; } //
        //public bool available { get; set; } //если о товарах,то есть ли в наличии на складе и сколько,не знаю,буду ли использовать 

        //public int categoryID { get; set; } //руки или ноги,это и будет категория,к которой будут относиться процедуры
        public ProcedureCategory ProcedureCategory { get; set; }
        //Relationships
        public List<Procedure_Reservation> Procedures_Reservations { get; set; }
    }
}