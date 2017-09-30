using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab13George.Models
{
    public class Lab13GeorgeContext : DbContext
    {
        public Lab13GeorgeContext (DbContextOptions<Lab13GeorgeContext> options)
            : base(options)
        {
        }

        public DbSet<Lab13George.Models.Student> Student { get; set; }
    }
}
