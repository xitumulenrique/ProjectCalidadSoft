using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class diagnosticointento2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<string>(
                name: "IdCie10",
                table: "DiagnosticoMedico",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico",
                columns: new[] { "IdCie10", "IdPacinete" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<string>(
                name: "CodigoCie10",
                table: "DiagnosticoMedico",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
