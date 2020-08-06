using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCarrito
{
    public class Sistema
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Producto> productos = new List<Producto>();
        private List<Compra> compras = new List<Compra>();
        private List<Administrador> administradores = new List<Administrador>();
        private static Sistema instancia;
        #region Propertys
        public static Sistema Instancia { get { if (instancia == null) { instancia = new Sistema(); } return instancia; } }
        public List<Producto> Productos { get { return productos; } }
        public List<Cliente> Clientes { get { return clientes; } }
        public List<Compra> Compras { get { return compras; } }
        public List<Administrador> Administradores { get { return administradores; } }
        #endregion
    }
}
