using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab13Cameron.Models
{
    public class Lab13CameronContext : DbContext
    {
        public Lab13CameronContext (DbContextOptions<Lab13CameronContext> options)
            : base(options)
        {
        }

        public DbSet<Lab13Cameron.Models.Register> Register { get; set; }
    }
}
