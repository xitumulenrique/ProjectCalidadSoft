using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class diagnosticointento1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_CodigoCie10Codigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_IdPacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_CodigoCie10Codigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_IdPacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "CodigoCie10Codigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdPacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<string>(
                name: "Cie10Codigo",
                table: "DiagnosticoMedico",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoCie10",
                table: "DiagnosticoMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPacinete",
                table: "DiagnosticoMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "DiagnosticoMedico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_Cie10Codigo",
                table: "DiagnosticoMedico",
                column: "Cie10Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_PacienteId",
                table: "DiagnosticoMedico",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_Cie10Codigo",
                table: "DiagnosticoMedico",
                column: "Cie10Codigo",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_PacienteId",
                table: "DiagnosticoMedico",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_Cie10Codigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_PacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_Cie10Codigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_PacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "Cie10Codigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "CodigoCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdPacinete",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<string>(
                name: "CodigoCie10Codigo",
                table: "DiagnosticoMedico",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPacienteId",
                table: "DiagnosticoMedico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_CodigoCie10Codigo",
                table: "DiagnosticoMedico",
                column: "CodigoCie10Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_IdPacienteId",
                table: "DiagnosticoMedico",
                column: "IdPacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_CodigoCie10Codigo",
                table: "DiagnosticoMedico",
                column: "CodigoCie10Codigo",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_IdPacienteId",
                table: "DiagnosticoMedico",
                column: "IdPacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
