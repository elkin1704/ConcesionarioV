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
        
        

        public DbSet<DatosCliente> DatosClientes { get; set; }
        public DbSet<Distribuidora> Distribuidoras { get; set; }
        public DbSet<InformeGasto> InformeGastos { get; set; }
        public DbSet<IngresoNeto> IngresoNetos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<RolPago> RolPagos { get; set; }
        public DbSet<TablaAmortizacion> TablaAmortizacions { get; set; }
        public DbSet<ResumenAmortizacion> ResumenAmortizacions { get; set; }
        
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connSQL = "server = DESKTOP-8BBLG0F\\SQLEXPRESS ; database=ConcesionarioV; user id=sa; password=1234";
            optionsBuilder.UseSqlServer(connSQL);
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Inventario>()
                .HasOne(inventario => inventario.Distribuidoras)
                .WithMany(distribuidora => distribuidora.Inventarios)
                .HasForeignKey(inv => inv.DistribuidoraId);

            model.Entity<RolPago>()
              .HasOne(rolpago => rolpago.DatosClientes)
              .WithMany(datocliente => datocliente.RolPagos)
              .HasForeignKey(rol => rol.DatosClienteId);

            model.Entity<IngresoNeto>()
             .HasOne(ingresoneto => ingresoneto.DatosClientes)
             .WithMany(datocliente => datocliente.IngresoNetos)
             .HasForeignKey(ing => ing.DatosClienteId);

            model.Entity<IngresoNeto>()
               .HasOne(ingresoneto => ingresoneto.RolPagos)
               .WithMany(rolpag => rolpag.IngresoNetos)
               .HasForeignKey(ing => ing.RolPagoId);

            model.Entity<IngresoNeto>()
                .HasOne(ingresoneto => ingresoneto.InformeGastos)
                .WithMany(informe => informe.IngresoNetos)
                .HasForeignKey(ing => ing.InformeGastoId); 

            model.Entity<ResumenAmortizacion>()
                .HasOne(resumen => resumen.DatosClientes)
                .WithMany(dato => dato.ResumenAmortizacions)
                .HasForeignKey(res => res.DatosClienteId); 
            model.Entity<ResumenAmortizacion>()
                .HasOne(resumen => resumen.IngresoNetos)
                .WithMany(ingresos => ingresos.ResumenAmortizacions)
                .HasForeignKey(res => res.IngresoNetoId); 


            
            //Periodo



        }
    }
    
}


