using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace ArtMombacho.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required(ErrorMessage = "El Nombre del Producto es Requerido.")]
        [MaxLength(45, ErrorMessage = "Solo puede tener como máximo 45 caracteres.")]
        public string Name { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio del producto es Requerido")]
        [Range(0.10, 100000, ErrorMessage = "El precio debe estar entre 0.10 y 100000")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La Descripcion es Requerida.")]
        public string Description { get; set; }

        [Display(Name = "Fecha en Stock (DD/MM/AA)")]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        /*[Display(Name = "URL de la imagen")]
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Debe agregar una imagen para el producto")]
        public string ImageUrl { get; set; }*/

        [Display(Name = "Categoría")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
        public virtual ICollection<File> Files { get; set; }

    }
}