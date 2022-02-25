using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class Venta
    {
        public int Id { get; set; }

        public int NumVenta { get; set; }

        public DateTime FechaVenta { get; set; }

        public decimal MontoTotal { get; set; }

        public int PuntoDeVentaId { get; set; }
        public virtual PuntoDeVenta PuntoDeVenta { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual List<LineaDeVenta> LineaDeVenta { get; set; }


        //Venta debe calcaular su total sumando los subtotales de las lineas de venta relacionadas.

        public void CalcularTotal()
        {
            foreach (var lv in LineaDeVenta)
            {

                MontoTotal += lv.CalcularSubtotal();

            }

        }



        //Debe definir un cliente por defecto por si en la venta no se ingresa un cliente 

        //Recorre la listadeventas


        public void ConfirmarVenta()
        {

            RecorrerListaVenta();

        }

        public void RecorrerListaVenta()
        {
            foreach (var lv in LineaDeVenta)
            {
                lv.CompararDatos();

            }

        }


    }


}
