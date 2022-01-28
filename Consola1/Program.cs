using ConcesionarioV.Entidades;
using System.Collections.Generic;
using ModeloDb;
using CargaDatos;

namespace Consola1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CargaInicial datos = new CargaInicial();
            var list = datos.Carga();

            //Extraer del diccionario las listas
            var listaInv = (List<Inventario>)list["Inventario"];
            var listaDis = (List<Distribuidora>)list["Distribuidora"];
            var listaDat = (List<DatosCliente>)list["DatosCliente"];
            var listaRolp = (List<RolPago>)list["RolPagos"];
            var listainfg = (List<InformeGasto>)list["InformeGastos"];
            var listataba = (List<TablaAmortizacion>)list["TablaAmortizacion"];
            var listaIngN = (List<IngresoNeto>)list["IngresosNetos"];
            var listaresA = (List<ResumenAmortizacion>)list["ResumenAmortizacion"];
            var listaFa = (List<FacturaDistribuidora>)list["FacturaDistribuidora"];

            using (DbConsecionaria repos = new DbConsecionaria())
            {
                repos.Inventarios.AddRange(listaInv);
                repos.Distribuidoras.AddRange(listaDis);
                repos.DatosClientes.AddRange(listaDat);
                repos.RolPagos.AddRange(listaRolp);
                repos.InformeGastos.AddRange(listainfg);
                repos.TablaAmortizacions.AddRange(listataba);
                repos.IngresoNetos.AddRange(listaIngN);
                repos.ResumenAmortizacions.AddRange(listaresA);
                repos.FacturaDistribuidoras.AddRange(listaFa);
                
                repos.SaveChanges();
            }
            
        }
    }
}
