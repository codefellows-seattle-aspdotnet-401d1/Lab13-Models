using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab13Models.Models
{
    public class Lab13ModelsContext : DbContext
    {
        public Lab13ModelsContext (DbContextOptions<Lab13ModelsContext> options)
            : base(options)
        {
        }

        public DbSet<Lab13Models.Models.StudentModel> StudentModel { get; set; }
    }
}
