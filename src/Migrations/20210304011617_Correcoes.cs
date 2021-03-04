using Microsoft.EntityFrameworkCore.Migrations;

namespace SisGerenciador.Migrations
{
    public partial class Correcoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "MatriculaDisciplinas",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "MatriculaDisciplinas",
                newName: "status");
        }
    }
}
