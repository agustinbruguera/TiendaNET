using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class Sucursal
    {
        public int Id { get; set; }

        public int Descripcion { get; set; }

        public virtual List<PuntoDeVenta> PuntoDeVenta { get; set; }

        public virtual List<Stock> Stock { get; set; }
    }
}
