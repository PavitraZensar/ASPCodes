using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureMiniProject.Models;

namespace AzureMiniProject.Data
{
    public class AzureMiniProjectContext : DbContext
    {
        public AzureMiniProjectContext (DbContextOptions<AzureMiniProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AzureMiniProject.Models.Product>? Product { get; set; }
    }
}
