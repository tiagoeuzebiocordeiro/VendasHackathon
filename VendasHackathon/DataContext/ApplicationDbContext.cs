using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VendasHackathon.Models;

namespace VendasHackathon.DataContext
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioModel, PerfilModel, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ItemVendaModel> ItensVenda { get; set; }
        public DbSet<VendaModel> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<VendaModel>()
                .HasMany(v => v.ItemsVenda)
                .WithOne(iv => iv.Venda)
                .HasForeignKey(v => v.VendaId)
                .IsRequired();

            base.OnModelCreating(builder);
        }
    }
}
