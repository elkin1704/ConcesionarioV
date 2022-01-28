using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class InformeGasto
    {
        public int InformeGastoId { get; set; }
        public string Cliente { get; set; }
        public decimal Agua { get; set; }
        public decimal Luz { get; set; }
        public decimal Telefono { get; set; }

        public decimal Otros_servicios { get; set; }

        public decimal Total { get; set; }

        
        // Relacion con datos cliente 1 a 1
        public int DatosClienteId { get; set; }

        public DatosCliente DatosClientes { get; set; }

        // Relacion con Ingresos Netos
        public ICollection<IngresoNeto> IngresoNetos { get; set; }


    }
}
