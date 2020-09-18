using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class tableciemodificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_IdPacienteNavigationId",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_IdPacienteNavigationId",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "CodigoCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdPacienteNavigationId",
                table: "DiagnosticoMedico");

            migrationBuilder.AddColumn<string>(
                name: "CodigoCie10Codigo",
                table: "DiagnosticoMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPacienteId",
                table: "DiagnosticoMedico",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CodigoCie10",
                table: "DiagnosticoMedico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "DiagnosticoMedico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPacienteNavigationId",
                table: "DiagnosticoMedico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico",
                column: "CodigoCie10NavigationCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_IdPacienteNavigationId",
                table: "DiagnosticoMedico",
                column: "IdPacienteNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_CodigoCie10NavigationCodigo",
                table: "DiagnosticoMedico",
                column: "CodigoCie10NavigationCodigo",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Paciente_IdPacienteNavigationId",
                table: "DiagnosticoMedico",
                column: "IdPacienteNavigationId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
