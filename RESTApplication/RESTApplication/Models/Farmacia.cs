using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Farmacia
    {
        [Key]
        public string empresa { get; set; }

        public List<Cliente> clientes { get; set; }
        public List<Doctor> doctores { get; set; }
        public List<Medicamento> medicamentos { get; set; }
        public List<Sucursal> sucursales { get; set; }
        public List<Pedido> pedidos { get; set; }


    }
}
