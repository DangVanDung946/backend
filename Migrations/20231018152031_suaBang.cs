using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class suaBang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SlidesList",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ProductsList",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "CategoriesList",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "ProductsList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductsList",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductsList");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SlidesList",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductsList",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CategoriesList",
                newName: "Title");
        }
    }
}
