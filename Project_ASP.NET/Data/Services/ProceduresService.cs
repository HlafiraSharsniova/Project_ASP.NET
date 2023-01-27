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
        public void Add(Procedure procedure)
        {
           _context.Procedures.Add(procedure);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Procedure>> GetAll()
        {
            var result = await _context.Procedures.ToListAsync();
            return result;
        }

        public Procedure GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Procedure Update(int id, Procedure newProcedure)
        {
            throw new NotImplementedException();
        }
    }
}
