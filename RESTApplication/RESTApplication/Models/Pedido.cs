using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Pedido
    {
        public int id { get; set; }

        [Required]
        public string sucursal { get; set; }

        [ForeignKey("Cliente")]
        public string cedulaCliente { get; set; }

        public Cliente cliente { get; set; }

        [Required]
        
        public string medicamentos { get; set; }

        [Required]
        public string horaRecojo { get; set; }

        [Required]
        public string receta { get; set; }

    }
}
