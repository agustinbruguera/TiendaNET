using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class PuntoDeVenta
    {
        public int Id { get; set; }

        public int numPtoVta { get; set; }

        public virtual List<Venta> Venta { get; set; }
    }
}
