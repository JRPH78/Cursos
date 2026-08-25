using Microsoft.EntityFrameworkCore;
using SistemaCompras.Server.Data_Entities;

namespace SistemaCompras.Server.Data_Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasIndex(x => x.Id)
                .IsUnique();
            modelBuilder.Entity<Venta>()
               .HasIndex(x => x.Id)
               .IsUnique();
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
