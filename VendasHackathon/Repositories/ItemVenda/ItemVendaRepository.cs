using VendasHackathon.DataContext;
using VendasHackathon.Models;

namespace VendasHackathon.Repositories.ItemVenda
{
    public class ItemVendaRepository : IItemVendaRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemVendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(ItemVendaModel itemVenda)
        {
            _context.ItensVenda.Add(itemVenda);
            _context.SaveChanges();
        }

        public IEnumerable<ItemVendaModel> GetAll()
        {
            return _context.ItensVenda.ToList();
        }

        public ItemVendaModel GetById(int id)
        {
            return _context.ItensVenda.Find(id);
        }

        public void Update(ItemVendaModel itemVenda)
        {
            _context.ItensVenda.Update(itemVenda);
            _context.SaveChanges();
        }
    }
}
