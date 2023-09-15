using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddProduitPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Produits",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Produits");
        }
    }
}
