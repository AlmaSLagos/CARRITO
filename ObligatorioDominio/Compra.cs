using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Compra
    {
        private int id;
        private static int ultId;
        private int formaPago;
        private int formaEntrega;
        private DateTime fechaCompra;
        private Cliente cliente;
        private List<UnProducto> producto= new List<UnProducto>();
        private bool terminada = false;
        public bool Terminada
        {
            get
            {
                return terminada;
            }
            set
            {
                terminada = value;
            }
        }
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
        public int FormaPago
        {
            get
            {
                return formaPago;
            }
            set
            {
                formaPago = value;
            }
        }
        public int FormaEntrega
        {
            get
            {
                return formaEntrega;
            }
            set
            {
                formaEntrega = value;
            }
        }
        public DateTime FechaCompra
        {
            get
            {
                return fechaCompra;
            }
            set
            {
                fechaCompra = value;
            }
        }
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }
        public List<UnProducto> Producto
        {
            get
            {
                return producto;
            }
            set
            {
                producto = value; 
            }
        }
       
        public Compra(int formaPago, int formaEntrega, DateTime fechaCompra, Cliente cliente)
        {
            Id = Compra.ultId;
            Compra.ultId++;
            FormaPago = formaPago;
            FormaEntrega = formaEntrega;
            FechaCompra = fechaCompra;
            Cliente = cliente;
        }
        public static bool ValidarFormaPago(int formaPago)
        {
            return formaPago == 1 || formaPago == 2;
        }
        public static bool ValidarFormaEntrega(int formaEntrega)
        {
            return formaEntrega == 1 || formaEntrega == 2;
        }
        public void AgregarProducto(Producto idProductoBuscado, double cantidad)
        {
            if (idProductoBuscado != null && cantidad >0)
            {
                UnProducto productoComprado = new UnProducto(idProductoBuscado, cantidad);
                producto.Add(productoComprado);
            }              
        }
        public void FinalizarUnaCompra()
        {
            Terminada = true;
        }
        public double Total()
        {
            double total = 0;
            for(int i=0; producto.Count>i; i++)
            {
                if (producto[i].IdProducto.TipoMoneda == "USD")
                {
                    total += producto[i].IdProducto.PrecioUnitario * 30 * producto[i].Cantidad;
                }
                 else{
                    total += producto[i].IdProducto.PrecioUnitario * producto[i].Cantidad;
                }                
            }
            return total;
        }
    }
}
