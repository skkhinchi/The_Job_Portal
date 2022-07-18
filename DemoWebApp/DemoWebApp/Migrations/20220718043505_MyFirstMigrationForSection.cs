using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebApp.Migrations
{
    public partial class MyFirstMigrationForSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Students",
                nullable: false,
                defaultValue: "NA");

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "Students");
        }
    }
}
