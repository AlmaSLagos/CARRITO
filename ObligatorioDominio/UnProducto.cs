using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class UnProducto
    {
        private Producto idProducto;
        private double cantidad;
        public Producto IdProducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }
        public double Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        public UnProducto(Producto idProducto, double cantidad)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
        public override string ToString()
        {
            string unProducto = "";
            unProducto = "Producto: " + idProducto + " - " + cantidad;         
            return unProducto;
        }
    }
}
