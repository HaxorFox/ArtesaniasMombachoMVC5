using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtMombacho.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "El Nombre de la Categoría es Requerido.")]
        [MaxLength(45,ErrorMessage = "El Nombre de la Categoría solo puede tener como máximo 45 caracteres.")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } 
    }
}