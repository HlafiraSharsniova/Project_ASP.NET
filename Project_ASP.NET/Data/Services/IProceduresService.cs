
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public interface IProceduresService
    {
        Task<IEnumerable<Procedure>> GetAllAsync();
        Task<Procedure> GetByIdAsync(int id);
        Task AddAsync(Procedure procedure);
        Task<Procedure> UpdateAsync(int id, Procedure newProcedure);
        Task DeleteAsync(int id);
    }

}

