using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategorieID",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Paniers_PanierId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Promotions_PromotionID",
                table: "Produits");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionID",
                table: "Produits",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PanierId",
                table: "Produits",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CategorieID",
                table: "Produits",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategorieID",
                table: "Produits",
                column: "CategorieID",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Paniers_PanierId",
                table: "Produits",
                column: "PanierId",
                principalTable: "Paniers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Promotions_PromotionID",
                table: "Produits",
                column: "PromotionID",
                principalTable: "Promotions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategorieID",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Paniers_PanierId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Promotions_PromotionID",
                table: "Produits");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionID",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PanierId",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategorieID",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategorieID",
                table: "Produits",
                column: "CategorieID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Paniers_PanierId",
                table: "Produits",
                column: "PanierId",
                principalTable: "Paniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Promotions_PromotionID",
                table: "Produits",
                column: "PromotionID",
                principalTable: "Promotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
