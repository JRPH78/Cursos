using Microsoft.EntityFrameworkCore;
using organigrama.Server.Data_Entities;


namespace organigrama.Server.Data_context
{
    public class OrganigramaDbContext : DbContext
    {
        public OrganigramaDbContext(DbContextOptions<OrganigramaDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<OrganigramaEntity> Organigrama { get; set; }
        
    }
}
