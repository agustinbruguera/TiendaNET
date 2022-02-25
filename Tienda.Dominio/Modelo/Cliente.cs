using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }

        public int Cuit { get; set; }

        public string RazonSocial { get; set; }

        public string Domicilio { get; set; }
    }
}
