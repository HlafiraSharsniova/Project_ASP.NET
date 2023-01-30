using Project_ASP.NET.Models;
using Project_ASP.NET.Data;
using Microsoft.EntityFrameworkCore;

namespace Project_ASP.NET.Data.Services
{
    public class ProceduresService : IProceduresService
    {
        private readonly AppDbContext _context;

        public ProceduresService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Procedure procedure)
        {
            await _context.Procedures.AddAsync(procedure);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Procedures.FirstOrDefaultAsync(n => n.ProcedureId == id);
            _context.Procedures.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Procedure>> GetAllAsync()
        {
            var result = await _context.Procedures.ToListAsync();
            return result;
        }



        public async Task<Procedure> GetByIdAsync(int id)
        {
            var result = await _context.Procedures.FirstOrDefaultAsync(n => n.ProcedureId == id);
            return result;
        }

        public async Task<Procedure> UpdateAsync(int id, Procedure newProcedure)
        {
            _context.Update(newProcedure);
            await _context.SaveChangesAsync();
            return newProcedure;
        }
    }
}
