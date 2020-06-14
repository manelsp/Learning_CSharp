using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Coches.Migrations
{
    public partial class MVCNuevaMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Matricula",
                table: "Coches",
                newName: "Matriucla");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Matriucla",
                table: "Coches",
                newName: "Matricula");
        }
    }
}
