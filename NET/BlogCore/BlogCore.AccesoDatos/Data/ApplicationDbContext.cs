using BlogCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //aqui se declaran las tablas o modelos que hemos creado
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Articulo> Articulo { get; set; }

    }
}
