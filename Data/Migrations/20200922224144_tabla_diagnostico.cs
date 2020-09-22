using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class tabla_diagnostico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_IdCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico");

            migrationBuilder.AlterColumn<string>(
                name: "IdCie10",
                table: "DiagnosticoMedico",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "IdDiagnostico",
                table: "DiagnosticoMedico",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico",
                column: "IdDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticoMedico_IdCie10",
                table: "DiagnosticoMedico",
                column: "IdCie10");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_IdCie10",
                table: "DiagnosticoMedico",
                column: "IdCie10",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_IdCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosticoMedico_IdCie10",
                table: "DiagnosticoMedico");

            migrationBuilder.DropColumn(
                name: "IdDiagnostico",
                table: "DiagnosticoMedico");

            migrationBuilder.AlterColumn<string>(
                name: "IdCie10",
                table: "DiagnosticoMedico",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiagnosticoMedico",
                table: "DiagnosticoMedico",
                columns: new[] { "IdCie10", "IdPaciente" });

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosticoMedico_Cie10_IdCie10",
                table: "DiagnosticoMedico",
                column: "IdCie10",
                principalTable: "Cie10",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
