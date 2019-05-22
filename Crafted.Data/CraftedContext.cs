using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Crafted.Data
{
    public class CraftedContext : DbContext
    {
        public CraftedContext(DbContextOptions context): base(context) {}

        public DbSet<Category> Categories { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }
        
        public DbSet<Modification> Modifications { get; set; }

        public DbSet<ModificationCategory> ModificationCategories { get; set; }
    }
}