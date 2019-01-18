using Microsoft.EntityFrameworkCore;
using Picks.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Picks.infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
