using Microsoft.EntityFrameworkCore;

namespace ClientesApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<InformacionCliente> InformacionCliente { get; set;
         }
    }
}
