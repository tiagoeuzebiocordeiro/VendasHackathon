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
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ClienteModel cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public ClienteModel GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void InativaCliente(int id)
        {
            ClienteModel cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                cliente.Ativo = false;
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
            }
        }

        public void Update(ClienteModel cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}
