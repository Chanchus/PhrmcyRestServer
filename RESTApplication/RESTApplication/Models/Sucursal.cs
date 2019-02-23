using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Sucursal
    {
        [Key]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        [Required]
        public string direccion { get; set; }

        [Required]
        public string administrador { get; set; }

        [ForeignKey("Farmacia")]
        public string empresa { get; set; }

        public Farmacia farmacia { get; set; }

    }
}
