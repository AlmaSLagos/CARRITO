using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCarrito
{
    public class UnProducto
    {
        private Producto producto;
        private double cantidad;

        public Producto Producto { get { return producto; } set { producto = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }

        public UnProducto(Producto producto, double cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            string unProducto = "";
            unProducto = "Producto: " + producto + " - " + cantidad;
            return unProducto;
        }
    }
}
