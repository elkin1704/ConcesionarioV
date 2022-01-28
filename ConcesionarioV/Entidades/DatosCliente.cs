using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class DatosCliente
    {
        public int DatosClienteId { get; set; }
        public string Nombres_Completos { get; set; }
        public String Correo { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        //
        public InformeGasto InformeGastos { get; set; }


        //Relacion Rol de pagos
        public ICollection<RolPago> RolPagos { get; set; }

       
    }
}
