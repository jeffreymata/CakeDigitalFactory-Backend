using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeDigitalFactory.Services.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encargos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTienda = table.Column<int>(type: "int", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    statusOrden = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fechaEncargo = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaEnvio = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaRecibido = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encargos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTienda = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    direccionTienda = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    correoTienda = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    telefonoTienda = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEncargo = table.Column<int>(type: "int", nullable: true),
                    numCai = table.Column<int>(type: "int", nullable: true),
                    numFactura = table.Column<int>(type: "int", nullable: true),
                    numCorrelativo = table.Column<int>(type: "int", nullable: true),
                    totalVenta = table.Column<int>(type: "int", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    idTienda = table.Column<int>(type: "int", nullable: true),
                    fechaVenta = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encargos");

            migrationBuilder.DropTable(
                name: "Tienda");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
