using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBaseExam5.Models;

namespace CodeBaseExam5.Data
{
    public class CodeBaseExam5Context : DbContext
    {
        public CodeBaseExam5Context (DbContextOptions<CodeBaseExam5Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBaseExam5.Models.Student> Student { get; set; }
    }
}
