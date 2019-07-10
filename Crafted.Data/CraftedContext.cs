using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
            var cascadeFKs = builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

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

            builder.Entity<Category>(c =>
            {
                c.ToTable("Categories");
                c.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                c.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });

            builder.Entity<HelpRequest>(hr =>
            {
                hr.ToTable("HelpRequests");
                hr.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                hr.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });

            builder.Entity<MenuItem>(mi =>
            {
                mi.ToTable("MenuItems");
                mi.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                mi.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });


            builder.Entity<Modification>(mod => 
            {
                mod.ToTable("Modifications");
                mod.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                mod.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });

            builder.Entity<ModificationCategory>(mc => 
            {
                mc.ToTable("ModificationCategories");
                mc.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                mc.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });


            builder.Entity<Order>(o => 
            {
                o.ToTable("Orders");
                o.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                o.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });

            builder.Entity<OrderItem>(oi =>
            {
                oi.ToTable("OrderItems");
                oi.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                oi.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });


            builder.Entity<Table>(t =>
            {
                t.ToTable("Tables");
                t.Property(m => m.DateCreated).HasDefaultValueSql("sysdatetimeoffset()");
                t.Property(m => m.DateModified).HasDefaultValueSql("sysdatetimeoffset()");
            });
                
        }
    }
}