using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public interface IProceduresService
    {
        Task<IEnumerable<Procedure>> GetAll();
        Procedure GetById(int id);
        void Add(Procedure procedure);
        Procedure Update(int id, Procedure newProcedure);
        void Delete(int id);
    }
}
