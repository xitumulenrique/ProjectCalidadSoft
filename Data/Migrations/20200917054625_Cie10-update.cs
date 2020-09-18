using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class Cie10update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cie10",
                columns: table => new
                {
                    Codigo = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cie10", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico",
                column: "CodigoCie10NavigationCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico",
                column: "CodigoCie10NavigationCodigo",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropTable(
                name: "Cie10");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico");
        }
    }
}
