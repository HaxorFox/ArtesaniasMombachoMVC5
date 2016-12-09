using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtMombacho.Models
{
    [Bind(Exclude = "Id")]
    public class CustomerOrder
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido")]
        [DisplayName("Nombre")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "El Apellido es Requerido")]
        [DisplayName("Apellido")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "La Dirección es Requerida")]
        [StringLength(70)]
        public string Address { get; set; }
        [Required(ErrorMessage = "La Ciudad es Requerida")]
        [StringLength(40)]
        public string City { get; set; }
        [Required(ErrorMessage = "El Municipio es Requerido")]
        [StringLength(40)]
        public string State { get; set; }
        [Required(ErrorMessage = "El Código Postal es Requerido")]
        [DisplayName("Código Postal")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "El País es Requerido")]
        [StringLength(40)]
        public string Country { get; set; }
        [Required(ErrorMessage = "El número de teléfono es Requerido.")]
        [StringLength(24)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "El Correo Electrónico es Requerido.")]
        [DisplayName("Correo Electrónico")]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Correo Electrónico no Válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
     
        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [ScaffoldColumn(false)]
        public Decimal Amount { get; set; }

        [ScaffoldColumn(false)]
        public string CustomerUserName { get; set; }

    }
}