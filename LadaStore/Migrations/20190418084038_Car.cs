using Microsoft.EntityFrameworkCore.Migrations;

namespace LadaStore.Migrations
{
    public partial class Car : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCustomer",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Siret",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsCustomer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Siret",
                table: "AspNetUsers");
        }
    }
}
