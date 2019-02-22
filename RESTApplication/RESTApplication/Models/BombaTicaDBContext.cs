using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class BombaTicaDBContext: DbContext
    {

        public BombaTicaDBContext(DbContextOptions<BombaTicaDBContext> options):base(options)
        {

        }


        public DbSet<Farmacia> bombaTicaDB { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
