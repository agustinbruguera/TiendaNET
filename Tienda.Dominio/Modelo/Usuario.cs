using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Pass { get; set; }

        public virtual List<Venta> Venta { get; set; }
    }
}
