using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalCodeBase.Models;

namespace FinalCodeBase.Data
{
    public class FinalCodeBaseContext : DbContext
    {
        public FinalCodeBaseContext (DbContextOptions<FinalCodeBaseContext> options)
            : base(options)
        {
        }

        public DbSet<FinalCodeBase.Models.Employee>? Employee { get; set; }
    }
}
