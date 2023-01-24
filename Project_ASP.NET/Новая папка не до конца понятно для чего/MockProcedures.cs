using Project_ASP.NET.Interfaces;
using Project_ASP.NET.Models;
using System;
using System.Collections.Generic;


namespace Project_ASP.NET.Новая_папка_не_до_конца_понятно_для_чего
{
    public class MockProcedures : IAllProcedures
    {
        private readonly IProceduresCategory _categoryProcedures = new MockCategory();

        public IEnumerable<Procedure> getFavProcedures { get; set; }
        public IEnumerable<Procedure> Procedures
        {
            get
            {
                return new List<Procedure>
                {
                    new Procedure {
                        Name = "Manicure", 
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 70,
                        isFavourite = true,
                        available = true, 
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Manicure for men",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 80,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Hybrid manicure",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 100,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Manicure + gel enhacement",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 120,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Extension S-M",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 160,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Extension L-XL",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 180,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Gel replenishment S-M",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 140,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Gel replenishment L-XL",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 160,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Design",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 20,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "French",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 30,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Removal",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 30,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Nail repair(1 nail)",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 10,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Nail extentions(1 nail)",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 15,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.First()
                    },
                    new Procedure {
                        Name = "Pedicure without hybrid (only toes)",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 110,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.Last()
                    },
                    new Procedure {
                        Name = "Full pedicure without hybrid",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 130,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.Last()
                    },
                    new Procedure {
                        Name = "Hybrid pedicure (only toes)",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 130,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.Last()
                    },
                    new Procedure {
                        Name = "Full hybrid pedicure",
                        shortDesc = " ",
                        longDesc = " ",
                        img = " ",
                        price = 150,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProcedures.AllCategories.Last()
                    }

                };
            }
        }
        public Procedure getObjectProcedure(int procedureID)
        {
            throw new NotImplementedException();
        }
    }
}
