using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class LineaDeVenta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public int VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

        public int TalleId { get; set; }
        public virtual Talle Talle { get; set; }

        public int ColorId { get; set; }
        public virtual Color Color { get; set; }



        //Linea de venta debe calcular el subtotal = producto.precio * cantidad

        public decimal CalcularSubtotal()
        {
            return Producto.PrecioVenta * Cantidad;
            
        }


        //Comparar

        public void CompararDatos()
        {
            var stock = Producto.Stock;

            foreach (var st in stock)
            {
                if(st.TalleId == TalleId && st.ColorId == ColorId)
                {
                    Producto.descontarStock(st,Cantidad);
                }

            }

        }

    }
}
