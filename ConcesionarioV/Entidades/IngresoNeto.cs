using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class IngresoNeto
    {
        public int IngresoNetoId{ get; set; }
        public string Cliente { get; set; }
        public decimal Rol_Pagos_Netos { get; set; }
        public decimal Servicios_Basicos_Netos { get; set; }
        public decimal Ingresos_Totales { get; set; }

        public decimal Valor_Aprobacion { get; set; }

        

        // Relacion con Rol de Pagos
        public RolPago RolPagos { get; set; }
        public int RolPagoId { get; set; }

        //Relacion con Informe Gastos
        public InformeGasto InformeGastos { get; set; }
        public int InformeGastoId { get; set; }

        //Relacion con Resumen Amortizacion
        public ICollection<ResumenAmortizacion> ResumenAmortizacions { get; set; }


    }
}
