using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCarrito
{
    public class Comun:Cliente
    {
        private string nombre;
        private int cedula;
        #region Property
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Cedula { get { return cedula; } set { cedula = value; } }
        #endregion
        #region HerenciaConstructor
        public Comun(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombre, int cedula) : base(mail, direccion, nombreUser, departamento, fechaRegistro, password)
        {
            Nombre = nombre;
            Cedula = cedula;
        }
        #endregion
        public override string ToString()
        {
            return base.ToString() + " Nombre del Cliente: " + Nombre + " Cedula: " + Cedula + " Celular: ";
        }
    }
}
