using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
   public class FacturaDistribuidora
    {
        public int InventarioId { get; set; }
        public Inventario Inventarios { get; set; }

        public string Fecha { get; set; }


        //Relacion con Actor
        public Distribuidora Distribuidoras { get; set; }

        public int DistribuidoraId { get; set; }
    }
}
