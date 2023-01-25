
using System.ComponentModel.DataAnnotations;
using Project_ASP.NET.Data.Enums;

namespace Project_ASP.NET.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; } //короткое описание

        public string img { get; set; }
        public double price { get; set; } //юшорт потому что цена не может быть с минусом и это не миллион знаков
        //public bool isFavourite { get; set; } //
        //public bool available { get; set; } //если о товарах,то есть ли в наличии на складе и сколько,не знаю,буду ли использовать 

        //public int categoryID { get; set; } //руки или ноги,это и будет категория,к которой будут относиться процедуры
        public ProcedureCategory ProcedureCategory { get; set; }
        //Relationships
        public List<Procedure_Reservation> Procedures_Reservations { get; set; }
    }
}