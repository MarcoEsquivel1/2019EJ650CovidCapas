using _2019EJ650CapasEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019EJ650CapasContexto
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }
        public DbSet<Departamentos> departamentos { get; set; }
        public DbSet<Generos> generos { get; set; }
        public DbSet<Casos> casos { get; set; }
    }
}
