﻿// <auto-generated />
using System;
using Crafted.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Crafted.Data.Migrations
{
    [DbContext(typeof(CraftedContext))]
    partial class CraftedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Crafted.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long?>("FacebookId");

                    b.Property<string>("FirstName");

                    b.Property<long?>("GoogleId");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Crafted.Data.AppUserTable", b =>
                {
                    b.Property<string>("AppUserId");

                    b.Property<int>("TableId");

                    b.HasKey("AppUserId", "TableId");

                    b.HasIndex("TableId");

                    b.ToTable("AppUserTable");
                });

            modelBuilder.Entity("Crafted.Data.BaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<DateTimeOffset?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BaseEntity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Crafted.Data.Category", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<int?>("CategoryId");

                    b.Property<int>("CategoryType");

                    b.Property<string>("ImageUrl");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("Crafted.Data.HelpRequest", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<string>("UserId");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("HelpRequest");
                });

            modelBuilder.Entity("Crafted.Data.MenuItem", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<float?>("ABV");

                    b.Property<bool>("Active");

                    b.Property<int?>("CategoryId")
                        .HasColumnName("MenuItem_CategoryId");

                    b.Property<string>("Comment");

                    b.Property<string>("Description");

                    b.Property<int?>("IBU");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("MenuItem_ImageUrl");

                    b.Property<string>("InternalName");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<decimal?>("Price");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("MenuItem");
                });

            modelBuilder.Entity("Crafted.Data.Modification", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<string>("Description")
                        .HasColumnName("Modification_Description");

                    b.Property<int?>("ModificationCategoryId");

                    b.Property<string>("Name")
                        .HasColumnName("Modification_Name");

                    b.Property<int?>("OrderItemId");

                    b.HasIndex("ModificationCategoryId");

                    b.HasIndex("OrderItemId");

                    b.HasDiscriminator().HasValue("Modification");
                });

            modelBuilder.Entity("Crafted.Data.ModificationCategory", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<string>("Description")
                        .HasColumnName("ModificationCategory_Description");

                    b.Property<int?>("MaxRequired");

                    b.Property<int?>("MenuItemId");

                    b.Property<int?>("MinRequired");

                    b.Property<string>("Name")
                        .HasColumnName("ModificationCategory_Name");

                    b.HasIndex("MenuItemId");

                    b.HasDiscriminator().HasValue("ModificationCategory");
                });

            modelBuilder.Entity("Crafted.Data.Order", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<int>("TableId");

                    b.Property<string>("UserId")
                        .HasColumnName("Order_UserId");

                    b.HasIndex("TableId");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("Order");
                });

            modelBuilder.Entity("Crafted.Data.OrderItem", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<int>("MenuItemId")
                        .HasColumnName("OrderItem_MenuItemId");

                    b.Property<int?>("OrderId");

                    b.Property<int>("TableId")
                        .HasColumnName("OrderItem_TableId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("TableId");

                    b.HasDiscriminator().HasValue("OrderItem");
                });

            modelBuilder.Entity("Crafted.Data.Table", b =>
                {
                    b.HasBaseType("Crafted.Data.BaseEntity");

                    b.Property<bool>("Active")
                        .HasColumnName("Table_Active");

                    b.Property<int>("Number");

                    b.HasDiscriminator().HasValue("Table");
                });

            modelBuilder.Entity("Crafted.Data.AppUserTable", b =>
                {
                    b.HasOne("Crafted.Data.AppUser", "AppUser")
                        .WithMany("AppUserTables")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Crafted.Data.Table", "Table")
                        .WithMany("AppUserTables")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Crafted.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Crafted.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Crafted.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Crafted.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Crafted.Data.Category", b =>
                {
                    b.HasOne("Crafted.Data.Category")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Crafted.Data.HelpRequest", b =>
                {
                    b.HasOne("Crafted.Data.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Crafted.Data.MenuItem", b =>
                {
                    b.HasOne("Crafted.Data.Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Crafted.Data.Modification", b =>
                {
                    b.HasOne("Crafted.Data.ModificationCategory")
                        .WithMany("Modifications")
                        .HasForeignKey("ModificationCategoryId");

                    b.HasOne("Crafted.Data.OrderItem")
                        .WithMany("Modifications")
                        .HasForeignKey("OrderItemId");
                });

            modelBuilder.Entity("Crafted.Data.ModificationCategory", b =>
                {
                    b.HasOne("Crafted.Data.MenuItem")
                        .WithMany("ModificationCategories")
                        .HasForeignKey("MenuItemId");
                });

            modelBuilder.Entity("Crafted.Data.Order", b =>
                {
                    b.HasOne("Crafted.Data.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Crafted.Data.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Crafted.Data.OrderItem", b =>
                {
                    b.HasOne("Crafted.Data.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Crafted.Data.Order")
                        .WithMany("MenuItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("Crafted.Data.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
