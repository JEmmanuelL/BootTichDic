using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta
{
    internal class ArticuloTich : IArticulo
    {
        public string imprimir()
        {
            return "Articulo de tich";
        }
    }
}
