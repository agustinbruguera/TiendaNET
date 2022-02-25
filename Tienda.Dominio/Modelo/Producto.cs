using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class Producto
    {

        /*
        public Producto()
        {
            Stock = new List<Stock>();
        }
        */


        public int Id { get; set; }

        public int CodigoProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public int PrecioVenta { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

        public int RubroId { get; set; }
        public virtual Rubro Rubro { get; set; }

        public virtual List<Stock> Stock { get; set; }

        //public ICollection<Stock> Stock { get; set; }

        //Producto tiene la responsabilidad de descontar el Stock

        public void descontarStock(Stock Stock, int cantidad)
        {
            Stock.Cantidad -= cantidad;

        }

    }
}
