using VendasHackathon.Models;

namespace VendasHackathon.Repositories.ItemVenda
{
    public interface IItemVendaRepository
    {
        IEnumerable<ItemVendaModel> GetAll();
        ItemVendaModel GetById(int id);
        void Update(ItemVendaModel itemVenda);
        //void Delete(int id); Não iremos deletar o item de uma venda!
        void Add(ItemVendaModel itemVenda);
    }
}
