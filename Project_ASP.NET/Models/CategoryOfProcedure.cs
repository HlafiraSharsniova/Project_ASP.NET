using System;
using System.Collections.Generic;


namespace Project_ASP.NET.Models
{
    public class CategoryOfProcedure
    {
     public int Id { get; set; }
     public string ProcedureName { get; set; }
     public string Description { get; set; } //описание услуги 

     public List<Procedure> procedures { get; set; }

     

    
    }
}
