using System.Diagnostics;
using System.Threading.Tasks;
using CrudNet8MVC.Datos;
using CrudNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Controllers
{
    public class InicioController : Controller
    {

        private readonly ApplicationDbContext _contexto;

        public InicioController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.FechaCreacion = DateTime.Now;

                _contexto.Contacto.Add(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id == null)
            {
                return NotFound();

            }


            var contacto = _contexto.Contacto.Find(id);

            if (contacto == null)
            {
                return NotFound();

            }

            return View(contacto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Contacto.Update(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            if (id == null)
            {
                return NotFound();

            }


            var contacto = _contexto.Contacto.Find(id);

            if (contacto == null)
            {
                return NotFound();

            }

            return View(contacto);
        }

        [HttpGet]
        public IActionResult Borrar(int id)
        {
            if (id == null)
            {
                return NotFound();

            }


            var contacto = _contexto.Contacto.Find(id);

            if (contacto == null)
            {
                return NotFound();

            }

            return View(contacto);
        }
        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarContacto(int id)
        {
            if (ModelState.IsValid)
            {
                var contacto= await _contexto.Contacto.FindAsync(id);
                if (contacto == null) 
                {
                    return View();
                }
                _contexto.Contacto.Remove(contacto);

                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));


            }
            return View();
        }





        //aqui termina el crud
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
