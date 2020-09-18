using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class diagnostico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosticoMedico",
                columns: table => new
                {
                    CodigoCie10 = table.Column<string>(nullable: true),
                    IdPaciente = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdPacienteNavigationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DiagnosticoMedico_Paciente_IdPacienteNavigationId",
                        column: x => x.IdPacienteNavigationId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_IdPacienteNavigationId",
                table: "DiagnosticoMedico",
                column: "IdPacienteNavigationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosticoMedico");
        }
    }
}
