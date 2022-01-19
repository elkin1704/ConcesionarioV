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
        public int Rol_Pagos_Netos { get; set; }
        public string Servicios_Basicos_Netos { get; set; }
        public string Ingresos_Totales { get; set; }

        public string Valor_Aprobacion { get; set; }

        // Relacion con Cliente
        public ICollection<DatosCliente> DatosClientes { get; set; }

        // Relacion con Rol de Pagos
        public ICollection<RolPago> RolPagos { get; set; }

        //Relacion con Informe Gastos
        public ICollection<InformeGasto> InformeGastos { get; set; }
    }
}
