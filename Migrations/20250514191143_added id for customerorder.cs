using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektuppgift.Migrations
{
    /// <inheritdoc />
    public partial class addedidforcustomerorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarRentalId",
                table: "CustomerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarRentalId",
                table: "CustomerOrders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerOrders");
        }
    }
}
