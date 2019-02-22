using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Pedido
    {
        public int id { get; set; }
        public string sucursal { get; set; }

        [ForeignKey("Cliente")]
        public int clienteId { get; set; }
        public Cliente cliente { get; set; }
        public string medicamentos { get; set; }
        public string horaRecojo { get; set; }
        public string receta { get; set; }

    }
}
