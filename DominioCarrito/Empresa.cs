using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCarrito
{
    public class Empresa:Cliente
    {
        private string nombreEmpresa;
        private string razonSocial;
        private long rut;
        #region Propertys
        public string NombreEmpresa { get { return nombreEmpresa; } set { nombreEmpresa = value; } }
        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public long Rut { get { return rut; } set { rut = value; } }
        #endregion
        #region HerenciaConstructor
        public Empresa(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombreEmpresa, string razonSocial, long rut) : base(mail, direccion, nombreUser, departamento, fechaRegistro, password)
        {
            NombreEmpresa = nombreEmpresa;
            RazonSocial = razonSocial;
            Rut = rut;
        }
        #endregion
        public override string ToString()
        {
            return base.ToString() + " Nombre de la Empresa: " + NombreEmpresa + " Razon Social: " + RazonSocial + " Rut: " + Rut;
        }
    }
}
