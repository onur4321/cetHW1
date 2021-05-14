using Microsoft.EntityFrameworkCore.Migrations;

namespace cetHW1.Data.Migrations
{
    public partial class age2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Students",
                newName: "NowAge");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NowAge",
                table: "Students",
                newName: "Age");
        }
    }
}
