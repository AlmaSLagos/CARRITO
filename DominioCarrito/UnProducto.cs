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
        #region Property
        public Producto Producto { get { return producto; } set { producto = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }
        #endregion
        #region Constructor
        public UnProducto(Producto producto, double cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
        #endregion
        public override string ToString()
        {
            string unProducto = "";
            unProducto = "Producto: " + producto + " X " + cantidad;
            return unProducto;
        }
    }
}
