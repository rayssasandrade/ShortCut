using Microsoft.EntityFrameworkCore.Migrations;

namespace SisGerenciador.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreRequisitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplinaRequeridaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRequisitos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreRequisitos_Disciplinas_DisciplinaRequeridaId",
                        column: x => x.DisciplinaRequeridaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreRequisitos_DisciplinaRequeridaId",
                table: "PreRequisitos",
                column: "DisciplinaRequeridaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreRequisitos");
        }
    }
}
