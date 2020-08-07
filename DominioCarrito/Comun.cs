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
        private string cedula;
        private string celular;
        #region Property
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Cedula { get { return cedula; } set { cedula = value; } }
        public string Celular { get { return celular; } set { celular = value; } }
        #endregion
        #region HerenciaConstructor
        public Comun(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombre, string cedula, string celular) : base(mail, direccion, nombreUser, departamento, fechaRegistro, password)
        {
            Nombre = nombre;
            Cedula = cedula;
            Celular = celular;
        }
        #endregion
        public override string ToString()
        {
            return base.ToString() + " Nombre del Cliente: " + Nombre + " Cedula: " + Cedula + " Celular: " + Celular;
        }
    }
}
