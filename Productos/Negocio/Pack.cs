using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Productos.Negocio
{
    internal class Pack : Producto
    {
        public int Cantidad { get; set; }

        public override double CalcularPrecio()
        {
            return Precio * Cantidad;
        }

    }
}
