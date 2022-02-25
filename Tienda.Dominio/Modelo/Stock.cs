using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class Stock
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }

        public int TalleId { get; set; }
        public virtual Talle Talle { get; set; }

        public int ColorId { get; set; }
        public virtual Color Color { get; set; }


        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

        //Descuento del Stock
    }
}
