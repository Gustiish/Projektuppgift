using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektuppgift.Migrations
{
    /// <inheritdoc />
    public partial class dsasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOrders_Cars_CarId",
                table: "CustomerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOrders_Customers_CustomerId",
                table: "CustomerOrders");

            migrationBuilder.DropIndex(
                name: "IX_CustomerOrders_CarId",
                table: "CustomerOrders");

            migrationBuilder.DropIndex(
                name: "IX_CustomerOrders_CustomerId",
                table: "CustomerOrders");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CustomerOrders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerOrders");

            migrationBuilder.AddColumn<int>(
                name: "CustomerOrderId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerOrderId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerOrderId",
                table: "Customers",
                column: "CustomerOrderId",
                unique: true,
                filter: "[CustomerOrderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CustomerOrderId",
                table: "Cars",
                column: "CustomerOrderId",
                unique: true,
                filter: "[CustomerOrderId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CustomerOrders_CustomerOrderId",
                table: "Cars",
                column: "CustomerOrderId",
                principalTable: "CustomerOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerOrders_CustomerOrderId",
                table: "Customers",
                column: "CustomerOrderId",
                principalTable: "CustomerOrders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CustomerOrders_CustomerOrderId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerOrders_CustomerOrderId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerOrderId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CustomerOrderId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CustomerOrderId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerOrderId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
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

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_CarId",
                table: "CustomerOrders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_CustomerId",
                table: "CustomerOrders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOrders_Cars_CarId",
                table: "CustomerOrders",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOrders_Customers_CustomerId",
                table: "CustomerOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
