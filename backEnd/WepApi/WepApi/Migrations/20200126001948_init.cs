using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WepApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    header = table.Column<string>(nullable: true),
                    body = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    body = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    questionFK = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_answers_questions_questionFK",
                        column: x => x.questionFK,
                        principalTable: "questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answers_questionFK",
                table: "answers",
                column: "questionFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answers");

            migrationBuilder.DropTable(
                name: "questions");
        }
    }
}
