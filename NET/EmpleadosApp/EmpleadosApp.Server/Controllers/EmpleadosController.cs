using EmpleadosApp.Server.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpleadosApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly EmpleadosDbContext _dbContext;
        public EmpleadosController(EmpleadosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("ReporteEmpleados")]
        public async Task<IActionResult> ReporteEmpleados(
        [FromQuery] int page,
        [FromQuery] int pageSize)
        {
            var query = _dbContext.Empleados
                .Where(e => e.Activo)
                .OrderBy(e => e.Id)
                .Select(e => new ReporteEmpleadoDto
                {
                    Id = e.Id,
                    Nombre = e.Nombre,
                    Departamento = e.Departamento.Nombre,
                    Puesto = e.Puesto.Nombre,
                    Usuario = e.Usuario.Nombre,
                    CantidadProyectos = e.Proyectos.Count()
                });

            var totalItems = await query.CountAsync();

            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var totalPages = (int)Math.Ceiling(
                (double)totalItems / pageSize
            );

            var resultado = new
            {
                Page = page,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = totalPages,
                Items = items,
            };

            return Ok(resultado);
        }
        [HttpGet("ObetenerEmpleados")]
        public async Task<IActionResult> ObtenerEmpleados(
            [FromQuery] int? cursor,
            [FromQuery] int pageSize =10
            )
        {
            var query = _dbContext.Empleados.Where(x=>x.Activo);

            if (cursor.HasValue)
            {
                query=query.Where(x=>x.Id>cursor.Value);
            }

            var items = await query
              .OrderBy(e => e.Id)
              .Select(e => new ReporteEmpleadoDto
              {
                  Id = e.Id,
                  Nombre = e.Nombre,
                  Departamento = e.Departamento.Nombre,
                  Puesto = e.Puesto.Nombre,
                  Usuario = e.Usuario.Nombre,
                  CantidadProyectos = e.Proyectos.Count()
              })
              .Take(pageSize)
              .ToListAsync();

            var nextCursor = items.LastOrDefault()?.Id;

            var resultado = new
            {
                PageSize = pageSize,
                NextCursor = nextCursor,
                Items = items
            };

            return Ok(resultado);

        }
    }
    public class ReporteEmpleadoDto
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Usuario { get; set; }
        public int CantidadProyectos { get; set; }
    }
}
