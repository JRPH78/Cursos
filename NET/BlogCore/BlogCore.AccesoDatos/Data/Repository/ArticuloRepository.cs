using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogCore.AccesoDatos.Data.Repository.IRepository;
using BlogCore.Data;
using BlogCore.Models;

namespace BlogCore.AccesoDatos.Data.Repository
{
    internal class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;
        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Articulo articulo)
        {
            var objDesdeDb = _db.Articulo.FirstOrDefault(s => s.Id == articulo.Id);
            if (objDesdeDb != null)
            {
                objDesdeDb.Nombre = articulo.Nombre;
                objDesdeDb.Descripcion = articulo.Descripcion;
                objDesdeDb.UrlImagen = articulo.UrlImagen;
                objDesdeDb.CategoriaId = articulo.CategoriaId;
                //_db.SaveChanges();
            }
        }

        Articulo IRepository<Articulo>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
