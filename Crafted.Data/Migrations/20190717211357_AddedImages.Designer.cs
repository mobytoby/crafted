﻿// <auto-generated />
using System;
using Crafted.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Crafted.Data.Migrations
{
    [DbContext(typeof(CraftedContext))]
    [Migration("20190717211357_AddedImages")]
    partial class AddedImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("TableId");

                    b.HasKey("AppUserId", "TableId");

                    b.HasIndex("TableId");

                    b.ToTable("AppUserTable");
                });

            modelBuilder.Entity("Crafted.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<int>("CategoryType");

                    b.Property<string>("ChangedBy");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<DateTimeOffset?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<int?>("ImageId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Crafted.Data.HelpRequest", b =>
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

                    b.Property<int?>("TableId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.HasIndex("UserId");

                    b.ToTable("HelpRequests");
                });

            modelBuilder.Entity("Crafted.Data.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Crafted.Data.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("ABV");

                    b.Property<bool>("Active");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("ChangedBy");

                    b.Property<string>("Comment");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<DateTimeOffset?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<string>("Description");

                    b.Property<int?>("IBU");

                    b.Property<int?>("ImageId");

                    b.Property<string>("InternalName");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<decimal?>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Crafted.Data.Modification", b =>
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

                    b.Property<string>("Description");

                    b.Property<int?>("ModificationCategoryId");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderItemId");

                    b.HasKey("Id");

                    b.HasIndex("ModificationCategoryId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("Modifications");
                });

            modelBuilder.Entity("Crafted.Data.ModificationCategory", b =>
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

                    b.Property<string>("Description");

                    b.Property<int?>("MaxRequired");

                    b.Property<int?>("MenuItemId");

                    b.Property<int?>("MinRequired");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.ToTable("ModificationCategories");
                });

            modelBuilder.Entity("Crafted.Data.Order", b =>
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

                    b.Property<int?>("TableId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Crafted.Data.OrderItem", b =>
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

                    b.Property<int?>("MenuItemId");

                    b.Property<int?>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Crafted.Data.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("ChangedBy");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<DateTimeOffset?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("sysdatetimeoffset()");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Tables");
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

            modelBuilder.Entity("Crafted.Data.Category", b =>
                {
                    b.HasOne("Crafted.Data.Category")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Crafted.Data.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Crafted.Data.HelpRequest", b =>
                {
                    b.HasOne("Crafted.Data.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId");

                    b.HasOne("Crafted.Data.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Crafted.Data.MenuItem", b =>
                {
                    b.HasOne("Crafted.Data.Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Crafted.Data.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
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
                        .HasForeignKey("TableId");

                    b.HasOne("Crafted.Data.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Crafted.Data.OrderItem", b =>
                {
                    b.HasOne("Crafted.Data.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId");

                    b.HasOne("Crafted.Data.Order")
                        .WithMany("MenuItems")
                        .HasForeignKey("OrderId");
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
#pragma warning restore 612, 618
        }
    }
}