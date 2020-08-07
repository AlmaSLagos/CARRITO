using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCarrito
{
    public class Producto
    {
        private int id;
        private static int ultId;
        private string nombreProducto;
        private string descripcion;
        private string categoria;
        private double precio;
        private string tipoMoneda;
        #region Property
        public int Id { get { return id; } set { id = value; } }
        public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string TipoMoneda { get { return tipoMoneda; } set { tipoMoneda = value; } }
        #endregion
        #region Constructor
        public Producto(string nombreProducto, string descripcion, string categoria, double precio, string tipoMoneda)
        {
            Id = Producto.ultId;
            Producto.ultId++;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            Categoria = categoria;
            Precio = precio;
            TipoMoneda = tipoMoneda;
        }
        #endregion
        public void ModificarDato(double precio, string tipoMoneda)
        {
            this.precio = precio;
            this.tipoMoneda = tipoMoneda;
        }
    }
}
