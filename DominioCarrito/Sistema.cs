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
        //Precargas
        #region Precarga
        public Sistema()
        {
            PrecargaAdmin();
            PrecargaCliente();
        }
        private void PrecargaAdmin()
        {
            AltaAdmin("administrador@gmail.com", "Admin123", "Reiko Miyamoto");
        }
        private void PrecargaCliente()
        {
            AltaClienteComun("cliente-comun@gmail.com", "Calle Sauce 235", "Juan Perez", 2, new DateTime(2019, 10, 25), "Comun123", "Juan Perez", 12345678);
            AltaClienteEmpresa("cliente-empresa@gmail.com", "18 de Julio 123", "Anna Ramirez", 1, new DateTime(2019, 10, 25), "Empresa123", "ROSA Restor", "ROSALES S.A.", 211234560051);
        }
        private void PrecargaDatosProducto()
        {
            AltaProducto("Papa Rosada Granel Kg", "Producto uruguayo", "Frescos", 53, "UYP");
            AltaProducto("Queso Muzzarella en fetas Kg", "Oferta, antes $340 el kilo.", "Frescos", 310, "UYP");
            AltaProducto("Tomate Americano Kg", "Producto no transgenico.", "Frescos", 124, "UYP");
            AltaProducto("Manzana Red Deliciosa Kg", "Producto uruguayo", "Frescos", 66, "UYP");
            AltaProducto("Hamburguesas Extra Grande x6", "Carne vacuna 6 unidades.", "Congelados", 310, "UYP");
            AltaProducto("Helado Crema sabor Vainilla 2L", "producto uruguayo", "Congelados", 347, "UYP");
            AltaProducto("Hamburguessa Clasica x2 167g", "Carne vacuna 2 unidades", "Congelados", 68, "UYP");
            AltaProducto("Chaja Petit", "Postre Helado 100g", "Congelados", 75, "UYP");
            AltaProducto("Pizza Americana x2 900g", "Pronta para calentar y comer. 2 Unidades.", "Congelados", 299, "UYP");
            AltaProducto("Fosforos extra largos", "caja 50 unidades", "Hogar", 38, "UYP");
            AltaProducto("Bolsas para freezer", "20x30cm 30 unidades", "Hogar", 82, "UYP");
            AltaProducto("Cloro para piscina 10Lt", "producto en oferta", "Hogar", 390, "UYP");
            AltaProducto("Repasador ajedres cuadros", "producto uruguayo 80% algodon", "Textiles", 115, "UYP");
            AltaProducto("Toalla de mano", "Blanca hotelera 50x90", "Textiles", 272, "UYP");
            AltaProducto("Delantal antimanchas c/peto", "forrado en pvc, resistente", "Textiles", 119, "UYP");
            AltaProducto("Edredon", "100% Poliester 2 plazas 2,10x2,30m", "Textiles", 1100, "UYP");
            AltaProducto("Champion lona adulto", "Tallas 36/41 variedad de colores", "Textiles", 390, "UYP");
            AltaProducto("SmartTV 55' Ultra HD", "Con 3 años de garantia", "Tecnologia", 529, "USD");
            AltaProducto("Playstation PS4 Sony", "Con 1 año de garantia con un juego de regalo.", "Tecnologia", 489, "USD");
            AltaProducto("Lavarropas Carga Frontal", "Lavado rapido 6Kg Con 3 años de garantia", "Tecnologia", 257, "USD");
        }
        #endregion
        //Busquedas.
        #region Busca Admin
        private Administrador BuscarAdmin(string mail)
        {
            int i = 0;
            Administrador admin = null;
            while (i < administradores.Count && admin == null)
            {
                if (administradores[i].Mail == mail)
                {
                    admin = (Administrador)administradores[i];
                }
                i++;
            }
            return admin;
        }
        #endregion
        #region Buscar Producto
        private Producto BuscarProducto(string nombreProducto)
        {
            int i = 0;
            Producto producto = null;
            while (i < productos.Count && producto == null)
            {
                if (productos[i].NombreProducto == nombreProducto)
                {
                    producto = productos[i];
                }
                i++;
            }
            return producto;
        }
        #endregion
        #region Buscar Producto
        private Producto BuscarProducto(int id)
        {
            int i = 0;
            Producto producto = null;
            while (i < productos.Count && producto == null)
            {
                if (productos[i].Id == id)
                {
                    producto = (Producto)productos[i];
                }
                i++;
            }
            return producto;
        }
        #endregion
        #region Buscar Cliente
        private Cliente BuscarCliente(string mail)
        {
            int i = 0;
            Cliente cliente = null;
            while (i < clientes.Count && cliente == null)
            {
                if (clientes[i].Mail == mail)
                {
                    cliente = (Cliente)clientes[i];
                }
                i++;
            }
            return cliente;
        }
        #endregion
        #region Buscar Compra
        private Compra BuscarCompra(int id)
        {
            int i = 0;
            Compra compra = null;
            while (i < compras.Count && compra == null)
            {
                if (compras[i].Id == id)
                {
                    compra = (Compra)compras[i];
                }
                i++;
            }
            return compra;
        }
        #endregion
        //Altas.
        #region Alta Admin
        public string AltaAdmin(string mail, string password, string nombreUser)
        {
            string mensajeUno = "El admin no se dio de alta";
            if (mail != "" && nombreUser != "" && password != "")
            {
                Administrador adminBuscado = BuscarAdmin(mail);
                if (adminBuscado == null)
                {
                    adminBuscado = new Administrador(mail, password, nombreUser);
                    administradores.Add(adminBuscado);
                    mensajeUno = "Se dio de alta correctamente";
                }
                else
                {
                    mensajeUno = "Ya existe un admin con ese mail";
                }
            }
            else
            {
                mensajeUno = "Los datos ingresados no son correctos";
            }
            return mensajeUno;
        }
        #endregion
        #region Alta Cliente Comun
        public string AltaClienteComun(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombre, int cedula)
        {
            string mensajeUno = "El cliente no se dio de alta";
            if (mail != "" && direccion != "" && nombreUser != "" && departamento > 0
                && password != "" && nombre != "" && cedula > 0 && Cliente.ValidarDepartamento(departamento) && mail != "alma@gmail.com")
            {
                Cliente clienteBuscado = BuscarCliente(mail);
                bool ciInvalido = VerificoCedula(cedula);
                bool mailInvalido = VerificoMail(mail);
                if (clienteBuscado == null && clienteBuscado is Comun && !ciInvalido && !mailInvalido)
                {
                    clienteBuscado = new Comun(mail, direccion, nombreUser, departamento, fechaRegistro, password, nombre, cedula);
                    clientes.Add(clienteBuscado);
                    mensajeUno = "El cliente se dio de alta correctamente";
                }
                else
                {
                    mensajeUno = "Ya existe un cliente con ese numero de cedula o mail";
                }
            }
            else
            {
                mensajeUno = "Los datos ingresados no son correctos";
            }
            return mensajeUno;
        }
        #endregion
        #region Alta Cliente Empresa
        public string AltaClienteEmpresa(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombreEmpresa, string razonSocial, long rut)
        {
            string mensajeDos = "La empresa no se dio de alta";
            if (mail != "" && direccion != "" && nombreUser != "" && departamento > 0
                && password != "" && nombreEmpresa != "" && razonSocial != "" && rut > 0 && Cliente.ValidarDepartamento(departamento) && mail != "alma@gmail.com")
            {
                Cliente clienteBuscado = BuscarCliente(mail);
                bool rutInvalido = VerificoRut(rut);
                bool mailInvalido = VerificoMail(mail);
                if (clienteBuscado == null && clienteBuscado is Empresa && !mailInvalido && !rutInvalido)
                {
                    clienteBuscado = new Empresa(mail, direccion, nombreUser, departamento, fechaRegistro, password, nombreEmpresa, razonSocial, rut);
                    clientes.Add(clienteBuscado);
                    mensajeDos = "La empresa con rut " + rut +
                        "se dio de alta correctamente";
                }
                else
                {
                    mensajeDos = "Ya existe una empresa con ese rut o mail";
                }
            }
            else
            {
                mensajeDos = "Los datos ingresados no son correctos";
            }
            return mensajeDos;
        }
        #endregion 
        #region Alta Producto
        public string AltaProducto(string nombreProducto, string descripcion, string categoria, double precio, string tipoMoneda)
        {
            string mensajeTres = "El producto no se dio de alta";
            if (nombreProducto != "" && descripcion != "" && categoria != "" && precio > 0
                && tipoMoneda != "")
            {
                Producto productoBuscado = BuscarProducto(nombreProducto);
                if (productoBuscado == null)
                {
                    productoBuscado = new Producto(nombreProducto, descripcion, categoria, precio, tipoMoneda);
                    productos.Add(productoBuscado);
                    mensajeTres = "El producto con id " + nombreProducto +
                        "se dio de alta correctamente";
                }
                else
                {
                    mensajeTres = "Ya existe un producto con ese id";
                }
            }
            else
            {
                mensajeTres = "Los datos ingresados no son correctos";
            }
            return mensajeTres;
        }
        #endregion
        #region Alta Compra
        public string AltaCompra(int formaPago, int formaEntrega, DateTime fechaCompra, string cliente)
        {
            string mensajeCuatro = "No se pudo hacer la compra";
            if (formaPago > 0 && cliente != "" && formaEntrega > 0 && Compra.ValidarFormaPago(formaPago) && Compra.ValidarFormaEntrega(formaEntrega))
            {
                Cliente clienteBuscado = BuscarCliente(cliente);
                if (clienteBuscado != null)
                {
                    Compra laCompra = new Compra(formaPago, formaEntrega, fechaCompra, clienteBuscado);
                    compras.Add(laCompra);
                    mensajeCuatro = "La compra se dio de alta";
                }
                else
                {
                    mensajeCuatro = "Mail incorrecto";
                }
            }
            else
            {
                mensajeCuatro = "Datos incorrectos";
            }
            return mensajeCuatro;
        }
        public string AltaUnaCompra(int idProducto, double cantidad, int idCompra)
        {
            string mensajeCinco = "No se pudo hacer la compra";
            if (cantidad > 0 && idProducto > 0)
            {
                Producto idProductoBuscado = BuscarProducto(idProducto);

                Compra compra = BuscarCompra(idCompra);
                if (idProductoBuscado != null && compra != null)
                {
                    compra.AgregarProducto(idProductoBuscado, cantidad);
                    mensajeCinco = "La compra se dio de alta";
                }
            }
            else
            {
                mensajeCinco = "Datos incorrectos";
            }
            return mensajeCinco;
        }
        #endregion
        //Otras.
        #region FINALIZAR COMPRA
        public string TerminarCompra(int idCompra)
        {
            string mensaje = "Selecione una compra para finalizar";
            Compra compraBuscada = BuscarCompra(idCompra);
            if (idCompra > 0)
            {
                compraBuscada.FinalizarUnaCompra();
                mensaje = "Finalizada";
            }
            return mensaje;
        }
        #endregion
        #region Total a Pagar
        public double TotalAPagar(int idCompra, double valorDolar)
        {
            double total = 0;
            if (idCompra > 0)
            {
                Compra compra = BuscarCompra(idCompra);
                total = compra.Total(valorDolar);
            }
            return total;
        }
        #endregion
        #region Cambiar precio de procuto
        public string ModificarProducto(int id, double precioUnitario, string tipoMoneda)
        {
            string mensaje = "no se cambio el precio";
            Producto producto = BuscarProducto(id);
            if (producto != null)
            {
                producto.ModificarDato(precioUnitario, tipoMoneda);
                mensaje = "El precio se cambio";
            }
            return mensaje;
        }
        #endregion
        //Validaciones.
        #region RUT
        private bool VerificoRut(long rut)
        {
            long digitos = (long)Math.Floor(Math.Log10(rut) + 1); //verifico cantidad de digitos.
            bool repetido = false;
            if (digitos == 12)
            {
                for (int i = 0; clientes.Count > i && !repetido; i++)
                {
                    if (((Empresa)clientes[i]).Rut == rut) //verifico que no se repita.
                    {
                        repetido = true;
                    }
                }
            }
            return repetido;
        }
        #endregion
        #region CI
        private bool VerificoCedula(int cedula)
        {
            int digitos = (int)Math.Floor(Math.Log10(cedula) + 1);
            bool repetido = false;
            if (digitos == 8)
            {
                for (int i = 0; clientes.Count > i && !repetido; i++)
                {
                    if (((Comun)clientes[i]).Cedula == cedula)
                    {
                        repetido = true;
                    }
                }
            }
            return repetido;
        }
        #endregion
        #region MAIL
        private bool VerificoMail(string mail)
        {
            bool repetido = false;
            for (int i = 0; clientes.Count > i && !repetido; i++)
            {
                if (clientes[i].Mail == mail)
                {
                    repetido = true;
                }
            }
            return repetido;
        }
        #endregion
        #region PASSWORD
        /*
        private bool VerificoPassword(string password)
        {
            bool passBien = false;
            //Creo la variable y dos contadores, uno para la letra y otro para los numeros.
            int i = 0, num = 0, letra = 0;
            //recorro en password y si encuentro letras las guardo en el contador letra y si encuentro numeros los guardo en el contador numeros. 
            while (i < password.Length)
            {
                var textoi = password[i].charCodeAt();
                if (textoi > 64 && textoi < 91 || textoi > 96 && textoi < 123)
                {
                    letra++;
                }
                else if (textoi > 47 && textoi < 58)
                {
                    num++;
              }
                i++;
            }
            //si el password tiene ambos contadores mayores a cero significa que el texto contiene por lo menos una letra y un numero :)
            if (num > 0 && letra > 0)
            {
                passBien = true;
            }
            return passBien;
        }
        */
        #endregion
    }
}
