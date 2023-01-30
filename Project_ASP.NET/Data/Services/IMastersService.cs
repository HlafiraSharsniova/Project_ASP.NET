
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public interface IMastersService 
    {


        Task<IEnumerable<Master>> GetAllAsync();
        Task<Master> GetByIdAsync(int id);
        Task AddAsync(Master master);
        Task<Master> UpdateAsync(int id, Master newMaster);
        Task DeleteAsync(int id);
    }
}
