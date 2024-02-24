using VendasHackathon.DataContext;
using VendasHackathon.Models;

namespace VendasHackathon.Repositories.Venda
{
    public class VendaRepository : IVendaRepository
    {
        private readonly ApplicationDbContext _context;
        public VendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(VendaModel venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            VendaModel venda = _context.Vendas.Find(id);
            if (venda != null)
            {
                _context.Vendas.Remove(venda);
                _context.SaveChanges();
            }
        }

        public IEnumerable<VendaModel> GetAll()
        {
            return _context.Vendas.ToList();
        }

        public VendaModel GetById(int id)
        {
            return _context.Vendas.Find(id);
        }

        public void Update(VendaModel venda)
        {
            _context.Vendas.Update(venda);
            _context.SaveChanges();
        }
    }
}
