using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SingularProductsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productSales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SalePrice = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SaleQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    SaleDate = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSales", x => x.SaleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productSales");
        }
    }
}
