using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class ResumenAmortizacion
    {
        public int ResumenAmortizacionId { get; set; }
        public string Cliente { get; set; }

        public decimal ValorPrestamo { get; set; }

        public decimal CuotaMensual { get; set; }
        public decimal SumaCuotas { get; set; }
        public decimal SumaInteres { get; set; }

        public string Prestamo { get; set; }

        

        // Relacion con Ingreso Neto
        public IngresoNeto IngresoNetos { get; set; }
        public int IngresoNetoId { get; set; }

        //Relacion con ResumenAmortizacion
        public TablaAmortizacion TablaAmortizacions { get; set; }
        public int TablaAmortizacionId { get; set; }
    }



}
