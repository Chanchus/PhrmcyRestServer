using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Doctor
    {
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidos { get; set; }

        [Key]
        [Required]
        public string cedula { get; set; }

        public string residencia { get; set; }

        public string nacimiento { get; set; }

        [Required]
        public int telefono { get; set; }

        [ForeignKey("Farmacia")]
        public string empresa { get; set; }

        public Farmacia farmacia { get; set; }


    }
}
