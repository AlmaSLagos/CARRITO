using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    class ClienteEmpresa:Cliente
    {
        private string nombreEmpresa;
        private string razonSocial;
        private string rut;
        public string NombreEmpresa
        {
            get
            {
                return nombreEmpresa;
            }
            set
            {
                nombreEmpresa = value;
            }
        }
        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }
            set
            {
                razonSocial = value;
            }
        }
        public string Rut
        {
            get
            {
                return rut;
            }
            set
            {
                rut = value;
            }
        }
        #region Constructor
        public ClienteEmpresa(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombreEmpresa, string razonSocial, string rut) : base(mail, direccion, nombreUser, departamento, fechaRegistro, password)
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
