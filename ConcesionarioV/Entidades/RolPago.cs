using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class RolPago
    {
        public int RolPagoId { get; set; }
        public string Cliente { get; set; }

        public string Cargo { get; set; }

        public decimal Sueldo { get; set; }
        public int Horas_extra { get; set; }

        public decimal Comision { get; set; }

        public decimal AporteIEES { get; set; }

        public decimal Anticipos { get; set; }

        public decimal Total { get; set; }

        // Relacion con DatosCliente
        public DatosCliente DatosClientes { get; set; }
        public int DatosClienteId { get; set; }

        //Relacion con Ingresos Netos
        public ICollection<IngresoNeto> IngresoNetos { get; set; }
    }
}
