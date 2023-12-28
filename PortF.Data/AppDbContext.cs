using Microsoft.EntityFrameworkCore;
using PortF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlogModel> Blogs { get; set; }
        public DbSet<WorkModel> Works { get; set; }

        

    }
}
