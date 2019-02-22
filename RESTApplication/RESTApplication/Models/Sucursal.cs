using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Sucursal
    {
        [Key]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public string administrador { get; set; }

    }
}
