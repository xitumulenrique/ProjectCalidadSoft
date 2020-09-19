using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class diagnosticointento7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PacienteId",
                table: "DiagnosticoMedico");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_IdPaciente",
                table: "DiagnosticoMedico",
                column: "IdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_IdCie10",
                table: "DiagnosticoMedico",
                column: "IdCie10",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_IdPaciente",
                table: "DiagnosticoMedico",
                column: "IdPaciente",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_IdCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_IdPaciente",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_IdPaciente",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<string>(
                name: "Cie10Codigo",
                table: "DiagnosticoMedico",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "DiagnosticoMedico",
                type: "int",
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
    }
}
