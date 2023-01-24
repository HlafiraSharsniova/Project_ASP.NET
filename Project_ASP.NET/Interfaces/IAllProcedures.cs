using Project_ASP.NET.Models;
using System;
using System.Collections.Generic;


namespace Project_ASP.NET.Interfaces
{
    public interface IAllProcedures
    {
        IEnumerable<Procedure> Procedures { get; }
        IEnumerable<Procedure> getFavProcedures{ get; set; }
        Procedure getObjectProcedure(int procedureID); //возвращает айди определенной услуги

    }
}
