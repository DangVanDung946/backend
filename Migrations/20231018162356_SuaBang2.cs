using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SuaBang2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "SlidesList",
                newName: "Short_Des");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "CategoriesList",
                newName: "Short_Des");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "SlidesList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Created_by",
                table: "SlidesList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "SlidesList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Delete",
                table: "SlidesList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Levels",
                table: "SlidesList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "SlidesList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Updated_by",
                table: "SlidesList",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "ProductsList",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "ProductsList",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "ProductsList",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "ProductsList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Created_by",
                table: "ProductsList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "ProductsList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Delete",
                table: "ProductsList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Short_Des",
                table: "ProductsList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "ProductsList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Updated_by",
                table: "ProductsList",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ImageIconsList",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "ImageIconsList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Created_by",
                table: "ImageIconsList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ImageIconsList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "ImageIconsList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Delete",
                table: "ImageIconsList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Levels",
                table: "ImageIconsList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "ImageIconsList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Updated_by",
                table: "ImageIconsList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "CategoriesList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Created_by",
                table: "CategoriesList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "CategoriesList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Delete",
                table: "CategoriesList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Levels",
                table: "CategoriesList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "CategoriesList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Updated_by",
                table: "CategoriesList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsersList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Admin = table.Column<bool>(type: "bit", nullable: true),
                    Last_Login = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: true),
                    Is_Delete = table.Column<bool>(type: "bit", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersList", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersList");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Created_by",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Is_Delete",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Levels",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Updated_by",
                table: "SlidesList");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Created_by",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Is_Delete",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Short_Des",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Updated_by",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Created_by",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Is_Delete",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Levels",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Updated_by",
                table: "ImageIconsList");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "CategoriesList");

            migrationBuilder.DropColumn(
                name: "Created_by",
                table: "CategoriesList");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "CategoriesList");

            migrationBuilder.DropColumn(
                name: "Is_Delete",
                table: "CategoriesList");

            migrationBuilder.DropColumn(
                name: "Levels",
                table: "CategoriesList");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "CategoriesList");

            migrationBuilder.DropColumn(
                name: "Updated_by",
                table: "CategoriesList");

            migrationBuilder.RenameColumn(
                name: "Short_Des",
                table: "SlidesList",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "Short_Des",
                table: "CategoriesList",
                newName: "Number");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "ProductsList",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Discount",
                table: "ProductsList",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryID",
                table: "ProductsList",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ImageIconsList",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
