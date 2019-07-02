using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Crafted.Data
{
    public class CraftedContext : IdentityDbContext<AppUser>
    {
        public CraftedContext(DbContextOptions context): base(context) {}

        public DbSet<Category> Categories { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }
        
        public DbSet<Modification> Modifications { get; set; }

        public DbSet<ModificationCategory> ModificationCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppUserTable>()
                .HasKey(aut => new { aut.AppUserId, aut.TableId });
            builder.Entity<AppUserTable>()
                .HasOne(aut => aut.AppUser)
                .WithMany(aut => aut.AppUserTables)
                .HasForeignKey(aut => aut.AppUserId);

            builder.Entity<AppUserTable>()
                .HasOne(aut => aut.Table)
                .WithMany(aut => aut.AppUserTables)
                .HasForeignKey(aut => aut.TableId);

        }
    }
}