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
    }
    
}


