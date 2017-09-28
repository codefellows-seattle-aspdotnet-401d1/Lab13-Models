using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab13_brian.Models
{
    public class lab13_brianContext : DbContext
    {
        public lab13_brianContext (DbContextOptions<lab13_brianContext> options)
            : base(options)
        {
        }

        public DbSet<lab13_brian.Models.Student> Student { get; set; }
    }
}
