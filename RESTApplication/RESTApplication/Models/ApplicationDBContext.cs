using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class ApplicationDBContext: DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }


        public DbSet<Farmacia> Farmacias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

    }
}
