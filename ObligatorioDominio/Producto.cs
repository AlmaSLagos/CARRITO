using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Producto
    {
        private int id;
        private static int ultId;
        private string nombreProducto;
        private string descripcion;
        private string exclusivo;
        private string categoria;
        private double precioUnitario;
        private string tipoMoneda;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }
            set
            {
                nombreProducto = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        public string Exclusivo
        {
            get
            {
                return exclusivo;
            }
            set
            {
                exclusivo = value;
            }
        }
        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }
        public double PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }
            set
            {
                precioUnitario = value;
            }
        }
        public string TipoMoneda
        {
            get
            {
                return tipoMoneda;
            }
            set
            {
                tipoMoneda = value;
            }
        }
        #region Constructor
        public Producto(string nombreProducto, string descripcion, string exclusivo, string categoria, double precioUnitario, string tipoMoneda)
        {
            Id = Producto.ultId;
            Producto.ultId++;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            Exclusivo = exclusivo;
            Categoria = categoria;
            PrecioUnitario = precioUnitario;
            TipoMoneda = tipoMoneda;
        }
        #endregion
        public void ModificarDato(double precioUnitario)
        {
            this.precioUnitario = precioUnitario;
        }

    }
}

