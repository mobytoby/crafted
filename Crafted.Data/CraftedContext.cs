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
        public DbSet<HelpRequest> HelpRequests { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUserTable>()
                .HasKey(aut => new { aut.AppUserId, aut.TableId });

            builder.Entity<AppUserTable>()
                .HasOne(aut => aut.AppUser)
                .WithMany(aut => aut.AppUserTables)
                .HasForeignKey(aut => aut.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AppUserTable>()
				.HasOne(aut => aut.Table)
				.WithMany(aut => aut.AppUserTables)
				.HasForeignKey(aut => aut.TableId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<BaseEntity>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("sysdatetimeoffset()");

            builder.Entity<BaseEntity>()
                .Property(b => b.DateModified)
                .HasDefaultValueSql("sysdatetimeoffset()");
        }
    }
}