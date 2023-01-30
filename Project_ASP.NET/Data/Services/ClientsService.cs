using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Models;

namespace Project_ASP.NET.Data.Services
{
    public class ClientsService : IClientsService
    {
        private readonly AppDbContext _context;

        public ClientsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var result = await _context.Clients.FirstOrDefaultAsync(n => n.ClientId == id);
            _context.Clients.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            var result = await _context.Clients.ToListAsync();
            return result;
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            var result = await _context.Clients.FirstOrDefaultAsync(n => n.ClientId == id);
            return result;
        }

        public async Task<Client> UpdateAsync(int id, Client newClient)
        {
            _context.Update(newClient);
            await _context.SaveChangesAsync();
            return newClient;
        }
    }
}
