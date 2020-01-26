using Microsoft.EntityFrameworkCore.Migrations;

namespace WepApi.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "answers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userName",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "answers");
        }
    }
}
