using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCarrito
{
    public abstract class Cliente
    {
        private string mail;
        private string direccion;
        private string nombreUser;
        private int departamento;
        private DateTime fechaRegistro;
        private string password;
        #region Propertys
        public string Mail { get { return mail; } set { mail = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string NombreUser { get { return nombreUser; } set { nombreUser = value; } }
        public int Departamento { get { return departamento; } set { departamento = value; } }
        public DateTime FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        public string Password { get { return password; } set { password = value; } }
        #endregion
        #region Constructor
        public Cliente(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password)
        {
            Mail = mail;
            Direccion = direccion;
            NombreUser = nombreUser;
            Departamento = departamento;
            FechaRegistro = fechaRegistro;
            Password = password;
        }
        #endregion
        #region Metodos
        public static bool ValidarDepartamento(int departamento)
        {
            return departamento == 1 || departamento == 2;
        }
        public override string ToString()
        {
            string unCliente = "";
            if (departamento == 1)
            {
                unCliente = "Nombre de Usuario: " + NombreUser + " Mail: " + Mail + " Direccion: " + Direccion + " Montevideo" + " Fecha de Registro: " + FechaRegistro;
            }
            else if (departamento == 2)
            {
                unCliente = "Nombre de Usuario: " + NombreUser + " Mail: " + Mail + " Direccion: " + Direccion + " Interior" + " Fecha de Registro: " + FechaRegistro;
            }
            return unCliente;
        }
        #endregion
    }
}
