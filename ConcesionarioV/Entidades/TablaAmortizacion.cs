using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class TablaAmortizacion
    {
        public int TablaAmortizacionId { get; set; }
        public string Cliente { get; set; }

        public string TNA30_360 { get; set; }
        public int Años { get; set; }
        public decimal ValorPrestamo { get; set; }
        public string Frecuencia { get; set; }

        public string InteresEquivalente { get; set; }

        public int Numeropagos { get; set; }

        public int NumeroCuotas { get; set; }

        //Relacion con Resumen Amortizacion
        public ICollection<ResumenAmortizacion> ResumenAmortizacions { get; set; }

        //Relacion con Inventario
        public Inventario Inventarios { get; set; }
        public int InventarioId { get; set; }
    }
}
