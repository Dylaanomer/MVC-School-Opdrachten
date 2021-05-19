using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class AddVak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vakken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DocentId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vakken_Docenten_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vakken_Studenten_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Studenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken",
                column: "DocentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_StudentId",
                table: "Vakken",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vakken");
        }
    }
}
