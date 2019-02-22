using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApplication.Models
{
    public class PhischelDB : DbContext
    {

        public PhischelDB(DbContextOptions<PhischelDB> options) : base(options)
        {

        }


        public DbSet<Farmacia> phischelDB { get; set; }
    }
}
