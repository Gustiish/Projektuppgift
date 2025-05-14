using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektuppgift.Migrations
{
    /// <inheritdoc />
    public partial class addedisloggedin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLoggedIn",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLoggedIn",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "Admins");
        }
    }
}
