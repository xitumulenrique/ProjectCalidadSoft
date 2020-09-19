using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class diagnosticointento3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdPacinete",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "DiagnosticoMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico",
                columns: new[] { "IdCie10", "IdPaciente" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdPacinete",
                table: "DiagnosticoMedico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico",
                columns: new[] { "IdCie10", "IdPacinete" });
        }
    }
}
