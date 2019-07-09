using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crafted.Data.Migrations
{
    public partial class TablesOrdersHelpRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modifications_ModificationCategories_ModificationCategoryId",
                table: "Modifications");

            migrationBuilder.DropTable(
                name: "ModificationCategories");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modifications",
                table: "Modifications");

            migrationBuilder.RenameTable(
                name: "Modifications",
                newName: "BaseEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Modifications_ModificationCategoryId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_ModificationCategoryId");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateModified",
                table: "BaseEntity",
                nullable: true,
                defaultValueSql: "sysdatetimeoffset()",
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "BaseEntity",
                nullable: false,
                defaultValueSql: "sysdatetimeoffset()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntity",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ABV",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuItem_CategoryId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IBU",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MenuItem_ImageUrl",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternalName",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modification_Description",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modification_Name",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModificationCategory_Description",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxRequired",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinRequired",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModificationCategory_Name",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_UserId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItem_MenuItemId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItem_TableId",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Table_Active",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppUserTable",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    TableId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTable", x => new { x.AppUserId, x.TableId });
                    table.ForeignKey(
                        name: "FK_AppUserTable_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppUserTable_BaseEntity_TableId",
                        column: x => x.TableId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CategoryId",
                table: "BaseEntity",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserId",
                table: "BaseEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_MenuItem_CategoryId",
                table: "BaseEntity",
                column: "MenuItem_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_OrderItemId",
                table: "BaseEntity",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_MenuItemId",
                table: "BaseEntity",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_TableId",
                table: "BaseEntity",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Order_UserId",
                table: "BaseEntity",
                column: "Order_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_OrderItem_MenuItemId",
                table: "BaseEntity",
                column: "OrderItem_MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_OrderId",
                table: "BaseEntity",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_OrderItem_TableId",
                table: "BaseEntity",
                column: "OrderItem_TableId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTable_TableId",
                table: "AppUserTable",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_CategoryId",
                table: "BaseEntity",
                column: "CategoryId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_AspNetUsers_UserId",
                table: "BaseEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_MenuItem_CategoryId",
                table: "BaseEntity",
                column: "MenuItem_CategoryId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ModificationCategoryId",
                table: "BaseEntity",
                column: "ModificationCategoryId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderItemId",
                table: "BaseEntity",
                column: "OrderItemId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_MenuItemId",
                table: "BaseEntity",
                column: "MenuItemId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_TableId",
                table: "BaseEntity",
                column: "TableId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_AspNetUsers_Order_UserId",
                table: "BaseEntity",
                column: "Order_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderItem_MenuItemId",
                table: "BaseEntity",
                column: "OrderItem_MenuItemId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderId",
                table: "BaseEntity",
                column: "OrderId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderItem_TableId",
                table: "BaseEntity",
                column: "OrderItem_TableId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_CategoryId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_AspNetUsers_UserId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_MenuItem_CategoryId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ModificationCategoryId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderItemId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_MenuItemId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_TableId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_AspNetUsers_Order_UserId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderItem_MenuItemId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_OrderItem_TableId",
                table: "BaseEntity");

            migrationBuilder.DropTable(
                name: "AppUserTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_CategoryId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_UserId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_MenuItem_CategoryId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_OrderItemId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_MenuItemId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_TableId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_Order_UserId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_OrderItem_MenuItemId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_OrderId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_OrderItem_TableId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ABV",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MenuItem_CategoryId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "IBU",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MenuItem_ImageUrl",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "InternalName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Modification_Description",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Modification_Name",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ModificationCategory_Description",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MaxRequired",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MinRequired",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ModificationCategory_Name",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Order_UserId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "OrderItem_MenuItemId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "OrderItem_TableId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Table_Active",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "BaseEntity");

            migrationBuilder.RenameTable(
                name: "BaseEntity",
                newName: "Modifications");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_ModificationCategoryId",
                table: "Modifications",
                newName: "IX_Modifications_ModificationCategoryId");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateModified",
                table: "Modifications",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValueSql: "sysdatetimeoffset()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Modifications",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "sysdatetimeoffset()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modifications",
                table: "Modifications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: true),
                    CategoryType = table.Column<int>(nullable: false),
                    ChangedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateModified = table.Column<DateTimeOffset>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ABV = table.Column<float>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    ChangedBy = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateModified = table.Column<DateTimeOffset>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IBU = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModificationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChangedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateModified = table.Column<DateTimeOffset>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MaxRequired = table.Column<int>(nullable: true),
                    MenuItemId = table.Column<int>(nullable: true),
                    MinRequired = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModificationCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModificationCategories_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_CategoryId",
                table: "MenuItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ModificationCategories_MenuItemId",
                table: "ModificationCategories",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modifications_ModificationCategories_ModificationCategoryId",
                table: "Modifications",
                column: "ModificationCategoryId",
                principalTable: "ModificationCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
