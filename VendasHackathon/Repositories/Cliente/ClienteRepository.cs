using Microsoft.EntityFrameworkCore;
using VendasHackathon.DataContext;
using VendasHackathon.Models;

namespace VendasHackathon.Repositories.Cliente
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public async Task<ClienteModel> GetByIdAsync(int? id)
        {
            return await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public void Update(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }
    }
}
