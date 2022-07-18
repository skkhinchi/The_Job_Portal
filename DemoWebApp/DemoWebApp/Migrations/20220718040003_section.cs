using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebApp.Migrations
{
    public partial class section : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Student",
                nullable: false,
                defaultValue: "NA"                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
