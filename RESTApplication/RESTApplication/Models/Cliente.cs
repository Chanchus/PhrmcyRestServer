using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Cliente
    {

        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidos { get; set; }
        [Required, MinLength(6), MaxLength(9)]
        public string cedula { get; set; }

        public string residencia { get; set; }
        [Required]
        public string nacimiento { get; set; }
        [MinLength(8), MaxLength(8)]
        public string telefono { get; set; }

        [ForeignKey("farmacia")]
        public string farmacia { get; set; }
    }
}