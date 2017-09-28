using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab13Tom.Models
{
    public class Lab13TomContext : DbContext
    {
        public Lab13TomContext (DbContextOptions<Lab13TomContext> options)
            : base(options)
        {
        }

        public DbSet<Lab13Tom.Models.Register> Register { get; set; }
    }
}
