using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    class Administrador
    {
        private string mail;
        private string password;
        private string nombreUser;
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string NombreUser
        {
            get
            {
                return nombreUser;
            }
            set
            {
                nombreUser = value;
            }
        }
        public Administrador(string mail, string password, string nombreUser)
        {
            Mail = mail;
            Password = password;
            NombreUser = nombreUser;

        }
    }
}
