using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Doctor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        public string residencia { get; set; }
        public string nacimiento { get; set; }
        public int telefono { get; set; }

    }
}
