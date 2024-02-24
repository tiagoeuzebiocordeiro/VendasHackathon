using VendasHackathon.Models;

namespace VendasHackathon.Repositories.Cliente
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteModel> GetAll();
        ClienteModel GetById(int id);
        void Update(ClienteModel cliente);
        void Delete(int id);
        void Add(ClienteModel cliente);
        void InativaCliente(int id);
    }
}
