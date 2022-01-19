using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDb.Migrations
{
    public partial class carga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unidades = table.Column<int>(type: "int", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio_por_unidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.InventarioId);
                });

            migrationBuilder.CreateTable(
                name: "ResumenAmortizacions",
                columns: table => new
                {
                    ResumenAmortizacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorPrestamo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CuotaMensual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SumaCuotas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SumaInteres = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prestamo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumenAmortizacions", x => x.ResumenAmortizacionId);
                });

            migrationBuilder.CreateTable(
                name: "TablaAmortizacions",
                columns: table => new
                {
                    TablaAmortizacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TNA30_360 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Años = table.Column<int>(type: "int", nullable: false),
                    ValorPrestamo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Frecuencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteresEquivalente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numeropagos = table.Column<int>(type: "int", nullable: false),
                    NumeroCuotas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaAmortizacions", x => x.TablaAmortizacionId);
                });

            migrationBuilder.CreateTable(
                name: "Distribuidoras",
                columns: table => new
                {
                    DistribuidoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distribuidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unidades = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InventarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidoras", x => x.DistribuidoraId);
                    table.ForeignKey(
                        name: "FK_Distribuidoras_Inventarios_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "Inventarios",
                        principalColumn: "InventarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngresoNetos",
                columns: table => new
                {
                    IngresoNetoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol_Pagos_Netos = table.Column<int>(type: "int", nullable: false),
                    Servicios_Basicos_Netos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingresos_Totales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor_Aprobacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumenAmortizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresoNetos", x => x.IngresoNetoId);
                    table.ForeignKey(
                        name: "FK_IngresoNetos_ResumenAmortizacions_ResumenAmortizacionId",
                        column: x => x.ResumenAmortizacionId,
                        principalTable: "ResumenAmortizacions",
                        principalColumn: "ResumenAmortizacionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InformeGastos",
                columns: table => new
                {
                    InformeGastoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agua = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Luz = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Telefono = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Otros_servicios = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IngresoNetoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformeGastos", x => x.InformeGastoId);
                    table.ForeignKey(
                        name: "FK_InformeGastos_IngresoNetos_IngresoNetoId",
                        column: x => x.IngresoNetoId,
                        principalTable: "IngresoNetos",
                        principalColumn: "IngresoNetoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolPagos",
                columns: table => new
                {
                    RolPagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sueldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Horas_extra = table.Column<int>(type: "int", nullable: false),
                    Comision = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AporteIEES = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Anticipos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IngresoNetoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPagos", x => x.RolPagoId);
                    table.ForeignKey(
                        name: "FK_RolPagos_IngresoNetos_IngresoNetoId",
                        column: x => x.IngresoNetoId,
                        principalTable: "IngresoNetos",
                        principalColumn: "IngresoNetoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatosClientes",
                columns: table => new
                {
                    DatosClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Completos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformeGastoId = table.Column<int>(type: "int", nullable: true),
                    IngresoNetoId = table.Column<int>(type: "int", nullable: true),
                    ResumenAmortizacionId = table.Column<int>(type: "int", nullable: true),
                    RolPagoId = table.Column<int>(type: "int", nullable: true),
                    TablaAmortizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosClientes", x => x.DatosClienteId);
                    table.ForeignKey(
                        name: "FK_DatosClientes_InformeGastos_InformeGastoId",
                        column: x => x.InformeGastoId,
                        principalTable: "InformeGastos",
                        principalColumn: "InformeGastoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosClientes_IngresoNetos_IngresoNetoId",
                        column: x => x.IngresoNetoId,
                        principalTable: "IngresoNetos",
                        principalColumn: "IngresoNetoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosClientes_ResumenAmortizacions_ResumenAmortizacionId",
                        column: x => x.ResumenAmortizacionId,
                        principalTable: "ResumenAmortizacions",
                        principalColumn: "ResumenAmortizacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosClientes_RolPagos_RolPagoId",
                        column: x => x.RolPagoId,
                        principalTable: "RolPagos",
                        principalColumn: "RolPagoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosClientes_TablaAmortizacions_TablaAmortizacionId",
                        column: x => x.TablaAmortizacionId,
                        principalTable: "TablaAmortizacions",
                        principalColumn: "TablaAmortizacionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosClientes_InformeGastoId",
                table: "DatosClientes",
                column: "InformeGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosClientes_IngresoNetoId",
                table: "DatosClientes",
                column: "IngresoNetoId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosClientes_ResumenAmortizacionId",
                table: "DatosClientes",
                column: "ResumenAmortizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosClientes_RolPagoId",
                table: "DatosClientes",
                column: "RolPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosClientes_TablaAmortizacionId",
                table: "DatosClientes",
                column: "TablaAmortizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuidoras_InventarioId",
                table: "Distribuidoras",
                column: "InventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InformeGastos_IngresoNetoId",
                table: "InformeGastos",
                column: "IngresoNetoId");

            migrationBuilder.CreateIndex(
                name: "IX_IngresoNetos_ResumenAmortizacionId",
                table: "IngresoNetos",
                column: "ResumenAmortizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolPagos_IngresoNetoId",
                table: "RolPagos",
                column: "IngresoNetoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosClientes");

            migrationBuilder.DropTable(
                name: "Distribuidoras");

            migrationBuilder.DropTable(
                name: "InformeGastos");

            migrationBuilder.DropTable(
                name: "RolPagos");

            migrationBuilder.DropTable(
                name: "TablaAmortizacions");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "IngresoNetos");

            migrationBuilder.DropTable(
                name: "ResumenAmortizacions");
        }
    }
}
