using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab13Erik.Model;

namespace Lab13Erik.Models
{
    public class Lab13ErikContext : DbContext
    {
        public Lab13ErikContext (DbContextOptions<Lab13ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab13Erik.Model.Student> Student { get; set; }
    }
}
