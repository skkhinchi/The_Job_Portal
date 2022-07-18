using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebApp.Migrations
{
    public partial class MyFirstMigrationForYear_of_enrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
             name: "year_of_enrollment",
             table: "Students",
             defaultValue: "2020",
             nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "year_of_enrollment",
               table: "Students");
        }
    }
}
