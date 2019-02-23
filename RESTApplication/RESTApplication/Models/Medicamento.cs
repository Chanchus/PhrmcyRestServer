using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class Medicamento
    {
        [Key]
        [Required]
        public string nombre { get; set; }

        [Required]
        public string farmaceutica { get; set; }

        [Required]
        public string prescripcion { get; set; }

        [Required]
        public int stock { get; set; }

    }
}
