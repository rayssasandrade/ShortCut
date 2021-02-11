using Microsoft.EntityFrameworkCore.Migrations;

namespace SisGerenciador.Migrations
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreRequisitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiberadaId = table.Column<int>(type: "int", nullable: false),
                    LiberadoraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRequisitos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreRequisitos_Disciplinas_LiberadaId",
                        column: x => x.LiberadaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreRequisitos_Disciplinas_LiberadoraId",
                        column: x => x.LiberadoraId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreRequisitos_LiberadaId",
                table: "PreRequisitos",
                column: "LiberadaId");

            migrationBuilder.CreateIndex(
                name: "IX_PreRequisitos_LiberadoraId",
                table: "PreRequisitos",
                column: "LiberadoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreRequisitos");
        }
    }
}
