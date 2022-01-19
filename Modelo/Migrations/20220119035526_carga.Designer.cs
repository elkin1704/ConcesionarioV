﻿// <auto-generated />
using System;
using ConcesionarioV.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ModeloDb.Migrations
{
    [DbContext(typeof(DbConsecionaria))]
    [Migration("20220119035526_carga")]
    partial class carga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConcesionarioV.Entidades.DatosCliente", b =>
                {
                    b.Property<int>("DatosClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InformeGastoId")
                        .HasColumnType("int");

                    b.Property<int?>("IngresoNetoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres_Completos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResumenAmortizacionId")
                        .HasColumnType("int");

                    b.Property<int?>("RolPagoId")
                        .HasColumnType("int");

                    b.Property<int?>("TablaAmortizacionId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("DatosClienteId");

                    b.HasIndex("InformeGastoId");

                    b.HasIndex("IngresoNetoId");

                    b.HasIndex("ResumenAmortizacionId");

                    b.HasIndex("RolPagoId");

                    b.HasIndex("TablaAmortizacionId");

                    b.ToTable("DatosClientes");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.Distribuidora", b =>
                {
                    b.Property<int>("DistribuidoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Distribuidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InventarioId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio_Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Unidades")
                        .HasColumnType("int");

                    b.HasKey("DistribuidoraId");

                    b.HasIndex("InventarioId");

                    b.ToTable("Distribuidoras");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.InformeGasto", b =>
                {
                    b.Property<int>("InformeGastoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Agua")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IngresoNetoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Luz")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Otros_servicios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Telefono")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InformeGastoId");

                    b.HasIndex("IngresoNetoId");

                    b.ToTable("InformeGastos");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.IngresoNeto", b =>
                {
                    b.Property<int>("IngresoNetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingresos_Totales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResumenAmortizacionId")
                        .HasColumnType("int");

                    b.Property<int>("Rol_Pagos_Netos")
                        .HasColumnType("int");

                    b.Property<string>("Servicios_Basicos_Netos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor_Aprobacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngresoNetoId");

                    b.HasIndex("ResumenAmortizacionId");

                    b.ToTable("IngresoNetos");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.Inventario", b =>
                {
                    b.Property<int>("InventarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio_por_unidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Unidades")
                        .HasColumnType("int");

                    b.HasKey("InventarioId");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.ResumenAmortizacion", b =>
                {
                    b.Property<int>("ResumenAmortizacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CuotaMensual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Prestamo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SumaCuotas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SumaInteres")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPrestamo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ResumenAmortizacionId");

                    b.ToTable("ResumenAmortizacions");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.RolPago", b =>
                {
                    b.Property<int>("RolPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Anticipos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AporteIEES")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Comision")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Horas_extra")
                        .HasColumnType("int");

                    b.Property<int?>("IngresoNetoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Sueldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RolPagoId");

                    b.HasIndex("IngresoNetoId");

                    b.ToTable("RolPagos");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.TablaAmortizacion", b =>
                {
                    b.Property<int>("TablaAmortizacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Años")
                        .HasColumnType("int");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frecuencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteresEquivalente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroCuotas")
                        .HasColumnType("int");

                    b.Property<int>("Numeropagos")
                        .HasColumnType("int");

                    b.Property<string>("TNA30_360")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorPrestamo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TablaAmortizacionId");

                    b.ToTable("TablaAmortizacions");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.DatosCliente", b =>
                {
                    b.HasOne("ConcesionarioV.Entidades.InformeGasto", null)
                        .WithMany("DatosClientes")
                        .HasForeignKey("InformeGastoId");

                    b.HasOne("ConcesionarioV.Entidades.IngresoNeto", null)
                        .WithMany("DatosClientes")
                        .HasForeignKey("IngresoNetoId");

                    b.HasOne("ConcesionarioV.Entidades.ResumenAmortizacion", null)
                        .WithMany("DatosClientes")
                        .HasForeignKey("ResumenAmortizacionId");

                    b.HasOne("ConcesionarioV.Entidades.RolPago", null)
                        .WithMany("DatosClientes")
                        .HasForeignKey("RolPagoId");

                    b.HasOne("ConcesionarioV.Entidades.TablaAmortizacion", null)
                        .WithMany("DatosClientes")
                        .HasForeignKey("TablaAmortizacionId");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.Distribuidora", b =>
                {
                    b.HasOne("ConcesionarioV.Entidades.Inventario", null)
                        .WithMany("Distribuidoras")
                        .HasForeignKey("InventarioId");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.InformeGasto", b =>
                {
                    b.HasOne("ConcesionarioV.Entidades.IngresoNeto", null)
                        .WithMany("InformeGastos")
                        .HasForeignKey("IngresoNetoId");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.IngresoNeto", b =>
                {
                    b.HasOne("ConcesionarioV.Entidades.ResumenAmortizacion", null)
                        .WithMany("IngresoNetos")
                        .HasForeignKey("ResumenAmortizacionId");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.RolPago", b =>
                {
                    b.HasOne("ConcesionarioV.Entidades.IngresoNeto", null)
                        .WithMany("RolPagos")
                        .HasForeignKey("IngresoNetoId");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.InformeGasto", b =>
                {
                    b.Navigation("DatosClientes");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.IngresoNeto", b =>
                {
                    b.Navigation("DatosClientes");

                    b.Navigation("InformeGastos");

                    b.Navigation("RolPagos");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.Inventario", b =>
                {
                    b.Navigation("Distribuidoras");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.ResumenAmortizacion", b =>
                {
                    b.Navigation("DatosClientes");

                    b.Navigation("IngresoNetos");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.RolPago", b =>
                {
                    b.Navigation("DatosClientes");
                });

            modelBuilder.Entity("ConcesionarioV.Entidades.TablaAmortizacion", b =>
                {
                    b.Navigation("DatosClientes");
                });
#pragma warning restore 612, 618
        }
    }
}
