using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.ViewModels
{
    public class NewReservationDropdownsVM

    { public NewReservationDropdownsVM()
        {
            Procedures = new List<Procedure>();
            Masters = new List<Master>();
            Clients = new List<Client>();
        }
        public List<Procedure> Procedures { get; set; }
        public List<Master> Masters { get; set; }
        public List<Client> Clients { get; set; }
    }
}
