using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab13Models.Models
{
    public class lab13ModelsContext : DbContext
    {
        public lab13ModelsContext (DbContextOptions<lab13ModelsContext> options)
            : base(options)
        {
        }

        public DbSet<lab13Models.Models.Students> Students { get; set; }
    }
}
