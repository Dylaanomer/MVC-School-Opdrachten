using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class VakStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Docenten_DocentId",
                table: "Vakken");

            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Studenten_StudentId",
                table: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Vakken",
                newName: "DocentenId");

            migrationBuilder.RenameColumn(
                name: "DocentId",
                table: "Vakken",
                newName: "Docent");

            migrationBuilder.RenameIndex(
                name: "IX_Vakken_StudentId",
                table: "Vakken",
                newName: "IX_Vakken_DocentenId");

            migrationBuilder.CreateTable(
                name: "VakStudent",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    VakId = table.Column<int>(type: "int", nullable: false),
                    Uren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VakStudent", x => new { x.StudentId, x.VakId });
                    table.ForeignKey(
                        name: "FK_VakStudent_Studenten_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Studenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VakStudent_Vakken_VakId",
                        column: x => x.VakId,
                        principalTable: "Vakken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VakStudent_VakId",
                table: "VakStudent",
                column: "VakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Docenten_DocentenId",
                table: "Vakken",
                column: "DocentenId",
                principalTable: "Docenten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Docenten_DocentenId",
                table: "Vakken");

            migrationBuilder.DropTable(
                name: "VakStudent");

            migrationBuilder.RenameColumn(
                name: "DocentenId",
                table: "Vakken",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Docent",
                table: "Vakken",
                newName: "DocentId");

            migrationBuilder.RenameIndex(
                name: "IX_Vakken_DocentenId",
                table: "Vakken",
                newName: "IX_Vakken_StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken",
                column: "DocentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Docenten_DocentId",
                table: "Vakken",
                column: "DocentId",
                principalTable: "Docenten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Studenten_StudentId",
                table: "Vakken",
                column: "StudentId",
                principalTable: "Studenten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
