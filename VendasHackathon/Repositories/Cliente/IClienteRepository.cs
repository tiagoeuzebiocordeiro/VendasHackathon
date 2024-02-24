using VendasHackathon.Models;

namespace VendasHackathon.Repositories.Cliente
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteModel> GetAllAsync();
        ClienteModel GetById(int id);
        void Update(ClienteModel cliente);
        void Delete(int id);
        void Add(ClienteModel cliente);
    }
}
