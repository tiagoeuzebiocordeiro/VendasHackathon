using VendasHackathon.Models;

namespace VendasHackathon.Repositories.Venda
{
    public interface IVendaRepository
    {
        IEnumerable<VendaModel> GetAll();
        VendaModel GetById(int id);
        void Add(VendaModel venda);
        void Update(VendaModel venda);
       // void Delete(int id); Não iremos deletar uma venda!
    }
}
