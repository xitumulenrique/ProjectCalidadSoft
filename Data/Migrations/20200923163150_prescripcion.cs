using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class prescripcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    IdMedicamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.IdMedicamento);
                });

            migrationBuilder.CreateTable(
                name: "Prescripcion",
                columns: table => new
                {
                    IdPrescripcion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    IdMedicamento = table.Column<int>(nullable: false),
                    MedicamentoIdMedicamento = table.Column<int>(nullable: true),
                    IdDiagnostico = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescripcion", x => x.IdPrescripcion);
                    table.ForeignKey(
                        name: "FK_Prescripcion_DiagnosticoMedico_IdDiagnostico",
                        column: x => x.IdDiagnostico,
                        principalTable: "DiagnosticoMedico",
                        principalColumn: "IdDiagnostico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescripcion_Medicamento_MedicamentoIdMedicamento",
                        column: x => x.MedicamentoIdMedicamento,
                        principalTable: "Medicamento",
                        principalColumn: "IdMedicamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescripcion_IdDiagnostico",
                table: "Prescripcion",
                column: "IdDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_Prescripcion_MedicamentoIdMedicamento",
                table: "Prescripcion",
                column: "MedicamentoIdMedicamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescripcion");

            migrationBuilder.DropTable(
                name: "Medicamento");
        }
    }
}
