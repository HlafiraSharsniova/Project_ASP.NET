using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Masters
                if (!context.Masters.Any())
                {
                    context.Masters.AddRange(new List<Master>()
                    {
                        new Master()
                        {
                            Name = "Glafira",
                            Bio = "Some information about me"
                        },
                    });

                    context.SaveChanges();

                }

                //Clients
                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(new List<Client>()
                    {
                        new Client()
                        {
                            Name = "Glafira",
                            Surname = "Some information about me",
                            PhoneNumber = 515947951,
                            Email = "shersnyovaglafira1736@gmail.com",
                            Password = "11111"
                        },
                    });

                    context.SaveChanges();
                }

                //Reservations
                if (!context.Reservations.Any())
                {
                    context.Reservations.AddRange(new List<Reservation>()
                    {

                         new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                          new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                           new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                            new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                             new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                              new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                               new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },

                          new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                           new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                            new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                             new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                              new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                               new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                                new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                                 new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                                  new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                            new Reservation()
                        {
                            NameOfReservation = "Reserved: Manicure",
                            DescriptionOfReservation = "Some information",
                            imgOfReservation = "",
                            priceOfReservation = 70,
                            DateOfReservation = DateTime.Now,
                            TimeOfReservation = DateTime.Now.AddMinutes(60),
                            MasterID = 1,
                            ClientID = 1
                        },
                    });
                    context.SaveChanges();

                }

                //Procedures
                if (!context.Procedures.Any())
                {
                    context.Procedures.AddRange(new List<Procedure>()
                    {

                        new Procedure ()

                        {
                            Name = "Manicure",
                            Desc = "Combined finger manicure.Without gel polish coating.",
                            img = "/img/mani.jpg",
                            price = 70,
                            ProcedureCategory = Enums.ProcedureCategory.Manicure

                        },
                        new Procedure ()
                        {
                            Name = "Manicure for men",
                            Desc = "Combined finger manicure.Without gel polish coating.",
                            img = "/img/men.jpg",
                            price = 80,
                            ProcedureCategory = Enums.ProcedureCategory.Manicure
                        },
                        new Procedure ()
                        {
                            Name = "Hybrid manicure",
                            Desc = "Combined manicure of fingers.With gel lacquer coating.",
                            img = "/img/one colour.jpg",
                            price = 100,
                            ProcedureCategory = Enums.ProcedureCategory.Manicure
                        },
                        new Procedure ()
                        {
                            Name = "Manicure + gel enhacement",
                            Desc = "Combined manicure of fingers.With gel coating.",
                            img = "/img/gel.jpg",
                            price = 120,
                            ProcedureCategory = Enums.ProcedureCategory.Manicure
                        },
                        new Procedure ()
                        {
                            Name = "Extension S-M",
                            Desc = "Combined manicure of fingers.With nail extension of length S-M.",
                            img = "/img/nara S.jpg",
                            price = 160,
                            ProcedureCategory = Enums.ProcedureCategory.NailExtentions
                        },
                        new Procedure ()
                        {
                            Name = "Extension L-XL",
                            Desc = "Combined manicure of fingers.With nail extension of length L-XL.",
                            img = "/img/nara XL.jpg",
                            price = 180,
                            ProcedureCategory = Enums.ProcedureCategory.NailExtentions
                        },
                        new Procedure ()
                        {
                            Name = "Gel replenishment S-M",
                            Desc = "Combined manicure of fingers.With gel replenishment of length S-M.",
                            img = "/img/wzm S.jpg",
                            price = 140,
                            ProcedureCategory = Enums.ProcedureCategory.NailExtentions
                        },
                        new Procedure ()
                        {
                            Name = "Gel replenishment L-XL",
                            Desc = "Combined manicure of fingers.With gel replenishment of length L-XL.",
                            img = "/img/wzmocn XL.jpg",
                            price = 160,
                            ProcedureCategory = Enums.ProcedureCategory.NailExtentions
                        },
                        new Procedure ()
                        {
                            Name = "Design",
                            Desc = "Any design on nails.",
                            img = "/img/design.jpg",
                            price = 20,
                            ProcedureCategory = Enums.ProcedureCategory.Additional
                        },
                        new Procedure ()
                        {
                            Name = "French",
                            Desc = "French.",
                            img = "/img/french.jpg",
                            price = 30,
                            ProcedureCategory = Enums.ProcedureCategory.Additional
                        },
                        new Procedure ()
                        {
                            Name = "Removal",
                            Desc = "Removing the coating from nails.",
                            img = "/img/snyatie.jpg",
                            price = 30,
                            ProcedureCategory = Enums.ProcedureCategory.Additional
                        },
                        new Procedure ()
                        {
                            Name = "Nail repair",
                            Desc = "Nail repair(1 nail).",
                            img = "/img/remont.jpg",
                            price = 10,
                            ProcedureCategory = Enums.ProcedureCategory.Additional
                        },
                        new Procedure ()
                        {
                            Name = "Nail extentions",
                            Desc = "Nail extentions(1 nail).",
                            img = "/img/nar 1.jpg",
                            price = 15,
                            ProcedureCategory = Enums.ProcedureCategory.Additional
                        },
                        new Procedure ()
                        {
                            Name = "Pedicure without hybrid (only toes)",
                            Desc = "Combined finger pedicure. Without gel polish coating.",
                            img = "/img/ped.jpg",
                            price = 110,
                            ProcedureCategory = Enums.ProcedureCategory.Pedicure
                        },
                        new Procedure()
                        {
                            Name = "Full pedicure without hybrid",
                            Desc = "Combined full pedicure. Without gel polish coating.",
                            img = "/img/full ped.jpg",
                            price = 130,
                            ProcedureCategory = Enums.ProcedureCategory.Pedicure

                        },
                        new Procedure()
                        {
                            Name = "Hybrid pedicure (only toes)",
                            Desc = "Combined pedicure of fingers. With gel lacquer coating.",
                            img = "/img/ped col.jpg",
                            price = 130,
                            ProcedureCategory = Enums.ProcedureCategory.Pedicure
                        },
                        new Procedure()
                        {
                            Name = "Full hybrid pedicure",
                            Desc = "Combined full pedicure. With gel lacquer coating.",
                            img = "/img/full ped colour.jpg",
                            price = 150,
                            ProcedureCategory = Enums.ProcedureCategory.Pedicure
                        }

                    });
                    context.SaveChanges();


                }
                //Procedures & Reservations
                if (!context.Procedures_Reservations.Any())
                {
                    context.Procedures_Reservations.AddRange(new List<Procedure_Reservation>()
                    {
                        new Procedure_Reservation()
                        {
                           ProcedureID = 1,
                           ReservationID = 1,
                        },
                         new Procedure_Reservation()
                        {
                           ProcedureID = 4,
                           ReservationID = 2,
                        },
                          new Procedure_Reservation()
                        {
                           ProcedureID = 7,
                           ReservationID = 3,
                        },
                           new Procedure_Reservation()
                        {
                           ProcedureID = 3,
                           ReservationID = 4,
                        },
                            new Procedure_Reservation()
                        {
                           ProcedureID = 7,
                           ReservationID = 5,
                        },
                             new Procedure_Reservation()
                        {
                           ProcedureID = 8,
                           ReservationID = 6,
                        },
                              new Procedure_Reservation()
                        {
                           ProcedureID = 5,
                           ReservationID = 7,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }

}
