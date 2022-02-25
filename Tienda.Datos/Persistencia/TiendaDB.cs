using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Dominio.Modelo;

namespace Tienda.Datos.Persistencia
{
    public class TiendaDB: DbContext
    {

        public TiendaDB(): base("TiendaDB")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Color> Colors { get; set; }

        public DbSet<LineaDeVenta> LineasDeVentas { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<PuntoDeVenta> PuntosDeVentas { get; set; }

        public DbSet<Rubro> Rubros { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Sucursal> Sucursales { get; set; }

        public DbSet<Talle> Talles { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Venta> Ventas { get; set; }



    }
}
