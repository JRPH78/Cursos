﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ingrese un nombre para la categorias")]
        [Display(Name ="Nombre de categoria")]
        public string Nombre { get; set; }
        [Display(Name = "Orden de visualización")]
        [Range(1, 100, ErrorMessage = "El orden debe estar entre 1 y 100")]  
        public int? Orden { get; set; }


    }
}
