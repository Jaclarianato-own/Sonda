using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sonda.Infrastructure.Data.Migrations
{
    public partial class cita1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cita",
                columns: table => new
                {
                    idCita = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idPaciente = table.Column<int>(type: "int", nullable: false),
                    nombrePaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    codigoServicio = table.Column<int>(type: "int", nullable: false),
                    nombreMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cita", x => x.idCita);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cita");
        }
    }
}
