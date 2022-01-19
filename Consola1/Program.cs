using ConcesionarioV.Entidades;
using System.Collections.Generic;
using ModeloDb;


namespace Consola1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ResumenAmortizacion Resumen = new ResumenAmortizacion()
            {
                Cliente = "Elkin David Romero Torres",
                ValorPrestamo = 32.000M,
                CuotaMensual = 734.37M,
                SumaCuotas = 88.12459M,
                SumaInteres = 50.12459M,
                Prestamo = "Aprobado",
                DatosClientes = new List<DatosCliente>() { new DatosCliente() { } },
                IngresoNetos = new List<IngresoNeto> { new IngresoNeto() { } }





            };

            // Grabar los datos
            using (DbConsecionaria repos = new DbConsecionaria())
            {
                repos.ResumenAmortizacions.AddRange(Resumen);
                repos.SaveChanges();
            }
        }
    }
}
