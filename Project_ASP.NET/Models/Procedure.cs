namespace Project_ASP.NET.Models
{
    public class Procedure
    {
     public int Id { get; set; }
     public string ProcedureName { get; set; }
     public string Description { get; set; } //описание услуги 

     public ushort Price { get; set; }

     public bool isFavourite { get; set; }//если тру,то эта услуга будет
                                          //отображаться на главной странице,
                                          //если фолс, то не будет
     public int Available { get; set; } 

     public List<Reservation> reservation { get; set; }

    }
}
