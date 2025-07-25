﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo: IDisposable
    {
        // Repositories se van agregando
        ICategoriaRepository Categoria { get; }
        IArticuloRepository Articulo { get; }

        void Save();
    }
    
}
