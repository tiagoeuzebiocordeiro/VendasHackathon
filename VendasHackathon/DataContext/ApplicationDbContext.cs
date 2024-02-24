using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VendasHackathon.Models;

namespace VendasHackathon.DataContext
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioModel, PerfilModel, int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ItemVendaModel> ItensVenda { get; set; }
        public DbSet<VendaModel> Vendas { get; set; }


    }
}
