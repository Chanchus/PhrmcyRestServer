using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class BombaTicaDB: DbContext
    {

        public BombaTicaDB(DbContextOptions<BombaTicaDB> options):base(options)
        {

        }


        public DbSet<Farmacia> bombaTicaDB { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
