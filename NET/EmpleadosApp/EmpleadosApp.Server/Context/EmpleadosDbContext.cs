using EmpleadosApp.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmpleadosApp.Server.Context
{
    public class EmpleadosDbContext: DbContext
    {
        public EmpleadosDbContext(DbContextOptions<EmpleadosDbContext> options) : base(options)

        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Empleado> Empleados {  get; set; }


    }
}
