using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models
{
    public class MummyDbContext : DbContext
    {
        public MummyDbContext (DbContextOptions<MummyDbContext> options) : base(options)
        {

        }

        public DbSet<Site> Sites { get; set; }
    }
}
