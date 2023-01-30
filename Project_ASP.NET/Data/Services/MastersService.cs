using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public class MastersService : IMastersService
    {
        private readonly AppDbContext _context;
        public MastersService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Master master)
        {
            await _context.Masters.AddAsync(master);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Masters.FirstOrDefaultAsync(n => n.MasterId == id);
            _context.Masters.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Master>> GetAllAsync()
        {
            var result = await _context.Masters.ToListAsync();
            return result;
        }

        public async Task<Master> GetByIdAsync(int id)
        {
            var result = await _context.Masters.FirstOrDefaultAsync(n => n.MasterId == id);
            return result;
        }

        public async Task<Master> UpdateAsync(int id, Master newMaster)
        {
            _context.Update(newMaster);
            await _context.SaveChangesAsync();
            return newMaster;
        }
    }
}
