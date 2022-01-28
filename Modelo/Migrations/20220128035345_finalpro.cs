using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDb.Migrations
{
    public partial class finalpro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosClientes",
                columns: table => new
                {
                    DatosClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Completos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosClientes", x => x.DatosClienteId);
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
                    Precio_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidoras", x => x.DistribuidoraId);
                });

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
                    DatosClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformeGastos", x => x.InformeGastoId);
                    table.ForeignKey(
                        name: "FK_InformeGastos_DatosClientes_DatosClienteId",
                        column: x => x.DatosClienteId,
                        principalTable: "DatosClientes",
                        principalColumn: "DatosClienteId",
                        onDelete: ReferentialAction.Cascade);
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
                    DatosClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPagos", x => x.RolPagoId);
                    table.ForeignKey(
                        name: "FK_RolPagos_DatosClientes_DatosClienteId",
                        column: x => x.DatosClienteId,
                        principalTable: "DatosClientes",
                        principalColumn: "DatosClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacturaDistribuidoras",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "int", nullable: false),
                    DistribuidoraId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaDistribuidoras", x => new { x.InventarioId, x.DistribuidoraId });
                    table.ForeignKey(
                        name: "FK_FacturaDistribuidoras_Distribuidoras_DistribuidoraId",
                        column: x => x.DistribuidoraId,
                        principalTable: "Distribuidoras",
                        principalColumn: "DistribuidoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaDistribuidoras_Inventarios_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "Inventarios",
                        principalColumn: "InventarioId",
                        onDelete: ReferentialAction.Cascade);
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
                    NumeroCuotas = table.Column<int>(type: "int", nullable: false),
                    InventarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaAmortizacions", x => x.TablaAmortizacionId);
                    table.ForeignKey(
                        name: "FK_TablaAmortizacions_Inventarios_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "Inventarios",
                        principalColumn: "InventarioId");
                });

            migrationBuilder.CreateTable(
                name: "IngresoNetos",
                columns: table => new
                {
                    IngresoNetoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol_Pagos_Netos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Servicios_Basicos_Netos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ingresos_Totales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Valor_Aprobacion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RolPagoId = table.Column<int>(type: "int", nullable: false),
                    InformeGastoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresoNetos", x => x.IngresoNetoId);
                    table.ForeignKey(
                        name: "FK_IngresoNetos_InformeGastos_InformeGastoId",
                        column: x => x.InformeGastoId,
                        principalTable: "InformeGastos",
                        principalColumn: "InformeGastoId");
                    table.ForeignKey(
                        name: "FK_IngresoNetos_RolPagos_RolPagoId",
                        column: x => x.RolPagoId,
                        principalTable: "RolPagos",
                        principalColumn: "RolPagoId");
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
                    Prestamo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngresoNetoId = table.Column<int>(type: "int", nullable: false),
                    TablaAmortizacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumenAmortizacions", x => x.ResumenAmortizacionId);
                    table.ForeignKey(
                        name: "FK_ResumenAmortizacions_IngresoNetos_IngresoNetoId",
                        column: x => x.IngresoNetoId,
                        principalTable: "IngresoNetos",
                        principalColumn: "IngresoNetoId");
                    table.ForeignKey(
                        name: "FK_ResumenAmortizacions_TablaAmortizacions_TablaAmortizacionId",
                        column: x => x.TablaAmortizacionId,
                        principalTable: "TablaAmortizacions",
                        principalColumn: "TablaAmortizacionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDistribuidoras_DistribuidoraId",
                table: "FacturaDistribuidoras",
                column: "DistribuidoraId");

            migrationBuilder.CreateIndex(
                name: "IX_InformeGastos_DatosClienteId",
                table: "InformeGastos",
                column: "DatosClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngresoNetos_InformeGastoId",
                table: "IngresoNetos",
                column: "InformeGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_IngresoNetos_RolPagoId",
                table: "IngresoNetos",
                column: "RolPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumenAmortizacions_IngresoNetoId",
                table: "ResumenAmortizacions",
                column: "IngresoNetoId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumenAmortizacions_TablaAmortizacionId",
                table: "ResumenAmortizacions",
                column: "TablaAmortizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolPagos_DatosClienteId",
                table: "RolPagos",
                column: "DatosClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaAmortizacions_InventarioId",
                table: "TablaAmortizacions",
                column: "InventarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturaDistribuidoras");

            migrationBuilder.DropTable(
                name: "ResumenAmortizacions");

            migrationBuilder.DropTable(
                name: "Distribuidoras");

            migrationBuilder.DropTable(
                name: "IngresoNetos");

            migrationBuilder.DropTable(
                name: "TablaAmortizacions");

            migrationBuilder.DropTable(
                name: "InformeGastos");

            migrationBuilder.DropTable(
                name: "RolPagos");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "DatosClientes");
        }
    }
}
