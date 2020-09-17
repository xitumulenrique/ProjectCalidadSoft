using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCalidadSoft.Data.Migrations
{
    public partial class prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactoFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Relacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoFamiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    LugarNacimiento = table.Column<string>(nullable: true),
                    Ocupacion = table.Column<string>(nullable: true),
                    TipoPaciente = table.Column<int>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    ContactoFamiliares = table.Column<int>(nullable: true),
                    TipoSangre = table.Column<int>(nullable: true),
                    Tutor = table.Column<int>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Peso = table.Column<string>(nullable: true),
                    Altura = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactoFamiliar");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
