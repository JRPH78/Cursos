using Microsoft.EntityFrameworkCore;
using Muebleria.Server.Data_Entities;

namespace Muebleria.Server.Data_context
{
    public class MuebleriaDbContext : DbContext
    {
        public MuebleriaDbContext(DbContextOptions<MuebleriaDbContext>options): base(options) 
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CatalogoEntity> Catalogos { get; set; }

    }
}
