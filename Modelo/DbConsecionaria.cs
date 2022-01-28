using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioV.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ModeloDb
{
    public class DbConsecionaria : DbContext
    {
        //Constructor invoca el constructor del padre
        public DbConsecionaria(DbContextOptions<DbConsecionaria> options)
            :base (options)    
        {

        }

        public DbSet<DatosCliente> DatosClientes { get; set; }
        public DbSet<Distribuidora> Distribuidoras { get; set; }
        public DbSet<InformeGasto> InformeGastos { get; set; }
        public DbSet<IngresoNeto> IngresoNetos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<RolPago> RolPagos { get; set; }
        public DbSet<TablaAmortizacion> TablaAmortizacions { get; set; }
        public DbSet<ResumenAmortizacion> ResumenAmortizacions { get; set; }

        public DbSet<FacturaDistribuidora> FacturaDistribuidoras { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connSQL = "server = DESKTOP-8BBLG0F\\SQLEXPRESS ; database=ConcesionarioV2; user id=sa; password=1234";
            optionsBuilder.UseSqlServer(connSQL);
        }
        */
        protected override void OnModelCreating(ModelBuilder model)
        {
            // Relacion de m a m Inventario y Distribuidora
            model.Entity<FacturaDistribuidora>()
                  .HasOne(factura_dis => factura_dis.Inventarios)
                  .WithMany(inv => inv.FacturaDistribuidoras)
                  .HasForeignKey(fac => fac.InventarioId);
            model.Entity<FacturaDistribuidora>()
                  .HasOne(factura_dis => factura_dis.Distribuidoras)
                  .WithMany(dis => dis.FacturaDistribuidoras)
                  .HasForeignKey(fac => fac.DistribuidoraId);

          

            model.Entity<FacturaDistribuidora>()
                .HasKey(factura_dis => new
                {
                    factura_dis.InventarioId,
                    factura_dis.DistribuidoraId
                });
            
            //Relacion 1 a 1

                model.Entity<DatosCliente>()
                .HasOne(datcli => datcli.InformeGastos)
                .WithOne(info => info.DatosClientes)
                .HasForeignKey<InformeGasto>(info => info.DatosClienteId);


             model.Entity<RolPago>()
              .HasOne(rolpago => rolpago.DatosClientes)
              .WithMany(datocliente => datocliente.RolPagos)
              .HasForeignKey(rol => rol.DatosClienteId);

         model.Entity<IngresoNeto>()
               .HasOne(ingresoneto => ingresoneto.RolPagos)
               .WithMany(rolpag => rolpag.IngresoNetos)
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey(ing => ing.RolPagoId);

            model.Entity<IngresoNeto>()
                .HasOne(ingresoneto => ingresoneto.InformeGastos)
                .WithMany(informe => informe.IngresoNetos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ing => ing.InformeGastoId); 

           
            model.Entity<ResumenAmortizacion>()
                .HasOne(resumen => resumen.IngresoNetos)
                .WithMany(ingresos => ingresos.ResumenAmortizacions)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(res => res.IngresoNetoId);

            model.Entity<ResumenAmortizacion>()
               .HasOne(resumen => resumen.TablaAmortizacions)
               .WithMany(tablaamor => tablaamor.ResumenAmortizacions)
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey(res => res.TablaAmortizacionId);

            model.Entity<TablaAmortizacion>()
               .HasOne(tab => tab.Inventarios)
               .WithMany(inv => inv.tablaAmortizacions)
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey(taba => taba.InventarioId);




            //Periodo



        }
    }
    
}


