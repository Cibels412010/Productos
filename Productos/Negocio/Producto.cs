using Productos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Negocio
{
    internal abstract class Producto : IPrecio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public abstract double CalcularPrecio();
        

        public override string ToString()
        {
            return Nombre;
        }
    }
}
