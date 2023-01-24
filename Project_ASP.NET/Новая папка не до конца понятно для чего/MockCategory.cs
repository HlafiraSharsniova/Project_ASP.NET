using Project_ASP.NET.Interfaces;
using Project_ASP.NET.Models;
using System;
using System.Collections.Generic;


namespace Project_ASP.NET.Новая_папка_не_до_конца_понятно_для_чего
{
    public class MockCategory : IProceduresCategory
    {
        public IEnumerable<CategoryOfProcedure> AllCategories
        {
            get
            {
                return new List<CategoryOfProcedure>
                {
                    new CategoryOfProcedure { ProcedureName = "Manicure", Description = "Все возможные услуги с руками" },
                    new CategoryOfProcedure { ProcedureName = "Pedicure", Description = "Все возможные процедуры с ногами" }

                };
            }
        }

    }
}
