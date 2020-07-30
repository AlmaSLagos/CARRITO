using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class HabiaUnaVez
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Producto> productos = new List<Producto>();
        private List<Compra> compras = new List<Compra>();
        private List<Administrador> administradores = new List<Administrador>();
        private static HabiaUnaVez instancia;
        #region Propertys
        public static HabiaUnaVez Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new HabiaUnaVez();
                }
                return instancia;
            }
        }
         public List<Producto> Productos
        {
            get { return productos; }
        }
        public List<Cliente> Clientes
        {
            get { return clientes; }
        }
        public List<Compra> Compras
        {
            get { return compras; }
        }
        #endregion
        public HabiaUnaVez()
        {
            PrecargaAdmin();
            PrecargaDatosClienteComun();
            PrecargaDatosClienteEmpresa();
            PrecargaDatosProducto();
            PrecargaDatosCompra();
            PonerEnCarrito();
        }
        //PRECARGAS
        #region Precarga Admin
        private void PrecargaAdmin()
        {
            AltaAdmin("alma@gmail.com", "1234", "Alma");
        }
        #endregion
        #region Precarga Datos Compra
        private void PrecargaDatosCompra()
        {
            AltaCompra(1, 2, new DateTime(2019, 10, 25), "compras@umbrella.com");
            AltaCompra(1, 1, new DateTime(2019, 10, 26), "capsuleadmin@capsule.com");
            AltaCompra(2, 2, new DateTime(2019, 10, 27), "juanes@gmail.com");
            AltaCompra(2, 1, new DateTime(2019, 10, 30), "juanes@gmail.com");
            AltaCompra(1, 2, new DateTime(2019, 11, 03), "rojas@gmail.com");
            AltaCompra(2, 2, new DateTime(2019, 11, 10), "mbonito@gmail.com");
            AltaCompra(1, 1, new DateTime(2019, 11, 12), "compras@umbrella.com");
            AltaCompra(1, 2, new DateTime(2019, 11, 12), "administracionkc@kaibacorp.com");
        }
        private void PonerEnCarrito()
        {
            AltaUnaCompra(1, 20,1);
            AltaUnaCompra(5, 200,2);
            AltaUnaCompra(9, 200,3);
            AltaUnaCompra(4, 10,4);
            AltaUnaCompra(1, 2,5);
            AltaUnaCompra(5, 1,6);
            AltaUnaCompra(10, 1,7);
            AltaUnaCompra(14, 3,8);
            AltaUnaCompra(3, 1,9);
            AltaUnaCompra(4, 2,10);
            AltaUnaCompra(20, 1,11);
            AltaUnaCompra(19, 1,12);
            AltaUnaCompra(16, 2,13);
            AltaUnaCompra(15, 1,14);
            AltaUnaCompra(12, 2,15);
            AltaUnaCompra(11, 500,16);
            AltaUnaCompra(19, 20,17);
            AltaUnaCompra(18, 30,18);
            AltaUnaCompra(14, 100,19);
        }
        #endregion
        #region Precarga Clientes
        private void PrecargaDatosClienteEmpresa()
        {
            AltaClienteEmpresa("capsuleadmin@capsule.com", "Japon 2427", "Bulma", 1, new DateTime(2019,01,20), "1234", "Corporacion Capsula", "Capsule Corporation", "1245678");
            AltaClienteEmpresa("administracionkc@kaibacorp.com", "Libertad 3188", "Seto", 1, new DateTime(2019,03,3), "1234","Kaiba Corp", "Kaiba Corporation", "01234567");
            AltaClienteEmpresa("compras@umbrella.com", "Raccoon 2256", "Nemesis", 2, new DateTime(2019,10,25), "1234", "Umbrella", "Umbrella Corporation", "98765432"); 
        }
        private void PrecargaDatosClienteComun()
        {
            AltaClienteComun("juanes@gmail.com", "Andes 123", "Juanez", 1, new DateTime(2019,06,20), "1234", "Juan Perez", "12345", "0945567");
            AltaClienteComun("rojas@gmail.com", "Rio Negro 2244", "Ana", 2, new DateTime(2019,07,13), "1234", "Ana Rojas", "67890", "0943333");
            AltaClienteComun("mbonito@gmail.com", "Brasil 135", "Maria", 2, new DateTime(2019,10,2), "1234", "Maria Bonito", "54321", "0914476");
        }
        #endregion
        #region Precarga Producto
        private void PrecargaDatosProducto()
        {
            AltaProducto("Papa Rosada Granel Kg","Producto uruguayo","Normal","Frescos",53,"UYP");
            AltaProducto("Queso Muzzarella en fetas Kg", "Oferta, antes $340 el kilo.", "Normal", "Frescos", 310, "UYP");
            AltaProducto("Tomate Americano Kg", "Producto no transgenico.", "Normal", "Frescos", 124, "UYP");
            AltaProducto("Manzana Red Deliciosa Kg", "Producto uruguayo", "Normal", "Frescos", 66, "UYP");
            AltaProducto("Hamburguesas Extra Grande x6", "Carne vacuna 6 unidades.", "Exclusivo", "Congelados", 310, "UYP");
            AltaProducto("Helado Crema sabor Vainilla 2L", "producto uruguayo", "Normal", "Congelados", 347, "UYP");
            AltaProducto("Hamburguessa Clasica x2 167g", "Carne vacuna 2 unidades", "Normal", "Congelados", 68, "UYP");
            AltaProducto("Chaja Petit", "Postre Helado 100g", "Normal", "Congelados", 75, "UYP");
            AltaProducto("Pizza Americana x2 900g", "Pronta para calentar y comer. 2 Unidades.", "Exclusivo", "Congelados", 299, "UYP");
            AltaProducto("Fosforos extra largos", "caja 50 unidades", "Normal", "Hogar", 38, "UYP");
            AltaProducto("Bolsas para freezer", "20x30cm 30 unidades", "Normal", "Hogar", 82, "UYP");
            AltaProducto("Cloro para piscina 10Lt", "producto en oferta", "Normal", "Hogar", 390, "UYP");
            AltaProducto("Repasador ajedres cuadros", "producto uruguayo 80% algodon", "Normal", "Textiles", 115, "UYP");
            AltaProducto("Toalla de mano", "Blanca hotelera 50x90", "Exclusivo", "Normal", 272, "UYP");
            AltaProducto("Delantal antimanchas c/peto", "forrado en pvc, resistente", "Normal", "Textiles", 119, "UYP");
            AltaProducto("Edredon", "100% Poliester 2 plazas 2,10x2,30m", "Exclusivo", "Textiles", 1100, "UYP");
            AltaProducto("Champion lona adulto", "Tallas 36/41 variedad de colores" , "Exclusivo", "Textiles", 390, "UYP");
            AltaProducto("SmartTV 55' Ultra HD", "Con 3 años de garantia", "Normal", "Tecnologia", 529, "USD");
            AltaProducto("Playstation PS4 Sony", "Con 1 año de garantia con un juego de regalo.", "Exclusivo", "Tecnologia", 489, "USD");
            AltaProducto("Lavarropas Carga Frontal", "Lavado rapido 6Kg Con 3 años de garantia", "Normal", "Tecnologia", 257, "USD");
        }
        #endregion
        //ADMIN
        #region Busca y Alta Admin
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
        public string AltaAdmin(string mail, string password, string nombreUser)
        {
            string mensajeUno = "El admin no se dio de alta";
            if (mail != ""&& nombreUser != "" && password != "" )
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
        //BUSCAR Y ALTA CLIENTES
        #region Buscar Cliente Comun
        private ClienteComun BuscarClienteComun(string mail, string cedula)
        {
            int i = 0;
            ClienteComun clienteComun = null;
            while (i < clientes.Count && clienteComun == null)
            {
                if(clientes[i].Mail==mail && clientes[i]is ClienteComun)
                {
                    if (((ClienteComun)clientes[i]).Cedula == cedula)
                    {
                        clienteComun = (ClienteComun)clientes[i];
                    }
                    
                }
                i++;
            }
            return clienteComun;
        }
        #endregion
        #region Alta Cliente Comun
        public string AltaClienteComun(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombre, string cedula, string celular)
        {
            string mensajeUno = "El cliente no se dio de alta";
            if (mail != "" && direccion != "" && nombreUser != "" && departamento > 0
                && password != "" && nombre != "" && cedula != "" && celular != "" && Cliente.ValidarDepartamento(departamento) && mail != "alma@gmail.com")
            {
                ClienteComun clienteBuscado = BuscarClienteComun(mail, cedula);
                if (clienteBuscado == null)
                {
                    clienteBuscado = new ClienteComun(mail, direccion, nombreUser, departamento, fechaRegistro, password, nombre, cedula, celular);
                    clientes.Add(clienteBuscado);
                    mensajeUno = "El cliente con cedula " + cedula +
                        "se dio de alta correctamente";
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
        #region Bucar Cliente Empresa

        private ClienteEmpresa BuscarClienteEmpresa(string mail, string rut)
        {
            int i = 0;
            ClienteEmpresa clienteEmpresa = null;
            while (i < clientes.Count && clienteEmpresa == null)
            {
                if (clientes[i].Mail == mail && clientes[i]is ClienteEmpresa) 
                {
                    if(((ClienteEmpresa)clientes[i]).Rut==rut)
                    clienteEmpresa = (ClienteEmpresa)clientes[i];
                }
                i++;
            }
            return clienteEmpresa;
        }
        #endregion
        //la vista de esto no funciona
        #region Alta Cliente Empresa
        public string AltaClienteEmpresa(string mail, string direccion, string nombreUser, int departamento, DateTime fechaRegistro, string password, string nombreEmpresa, string razonSocial, string rut)
        {
            string mensajeDos = "La empresa no se dio de alta";
            if (mail != "" && direccion != "" && nombreUser != "" && departamento > 0
                && password != "" && nombreEmpresa != "" && razonSocial != "" && rut != "" && Cliente.ValidarDepartamento(departamento) && mail != "alma@gmail.com")
            {
                ClienteEmpresa clienteBuscado = BuscarClienteEmpresa(mail, rut);
                if (clienteBuscado == null)
                {
                    clienteBuscado = new ClienteEmpresa(mail, direccion, nombreUser, departamento, fechaRegistro, password, nombreEmpresa, razonSocial, rut);
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
        //BUSCAR Y ALTA PRODUCTO (Admin)
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
        #region Alta Producto
        public string AltaProducto(string nombreProducto, string descripcion, string exclusivo, string categoria, double precioUnitario, string tipoMoneda)
        {
            string mensajeTres = "El producto no se dio de alta";
            if (nombreProducto != "" && descripcion != "" && categoria !="" && precioUnitario > 0
                && exclusivo !="" && tipoMoneda != "")
            {
                Producto productoBuscado = BuscarProducto(nombreProducto);
                if (productoBuscado == null)
                {
                    productoBuscado = new Producto(nombreProducto, descripcion, exclusivo, categoria, precioUnitario, tipoMoneda);
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
        //COMPRAR:
        //buscar
        #region Buscar Id del Producto
        private Producto BuscarIdProducto(int id)
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
        #region Buscar Id de una Compra
        private Compra BuscarIdCompra(int id)
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
        //comprar (Cliente)
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
                Producto idProductoBuscado = BuscarIdProducto(idProducto);

                Compra compra = BuscarIdCompra(idCompra); 
                if(idProductoBuscado!= null && compra != null)
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
        #region FINALIZAR COMPRA
        public string TerminarCompra(int idCompra)
        {
            string mensaje = "Selecione una compra para finalizar";
            Compra compraBuscada = BuscarIdCompra(idCompra);
            if (idCompra >0)
            {
                compraBuscada.FinalizarUnaCompra();
                mensaje = "Finalizada";
            }
            return mensaje;
        }
        #endregion
        //MOSTRAR (Admin)
        #region Mostrar los Clientes

        public string MostrarClientesComunes()
        {
            string losClientes = "";
            for (int i = 0; i < clientes.Count && clientes[i] is ClienteComun; i++)
            {
                if (clientes[i].Departamento == 1)
                {
                    losClientes = "Nombre de Usuario: " + clientes[i].NombreUser + "Mail: " + clientes[i].Mail + "Direccion: " + clientes[i].Direccion + "Montevideo" + "Fecha de Registro: " + clientes[i].FechaRegistro + " Nombre del Cliente: " + ((ClienteComun)clientes[i]).Nombre + " Cedula: " + ((ClienteComun)clientes[i]).Cedula + " Celular: " + ((ClienteComun)clientes[i]).Celular + "\n";
                }
                else if (clientes[i].Departamento == 2)
                {
                    losClientes = "Nombre de Usuario: " + clientes[i].NombreUser + "Mail: " + clientes[i].Mail + "Direccion: " + clientes[i].Direccion + "Interior" + "Fecha de Registro: " + clientes[i].FechaRegistro + " Nombre del Cliente: " + ((ClienteComun)clientes[i]).Nombre + " Cedula: " + ((ClienteComun)clientes[i]).Cedula + " Celular: " + ((ClienteComun)clientes[i]).Celular + "\n";
                }

            }
            return losClientes;
        }
        public string MostrarClientesEmpresas()
        {
            string losClientes = "";
            for (int i = 0; i < clientes.Count && clientes[i] is ClienteEmpresa; i++)
            {
                if (clientes[i].Departamento == 1)
                {
                    losClientes = "Nombre de Usuario: " + clientes[i].NombreUser + "Mail: " + clientes[i].Mail + "Direccion: " + clientes[i].Direccion + "Montevideo" + "Fecha de Registro: " + clientes[i].FechaRegistro + " Nombre de la Empresa: " + ((ClienteEmpresa)clientes[i]).NombreEmpresa + " RazonSocial: " + ((ClienteEmpresa)clientes[i]).RazonSocial + " Rut: " + ((ClienteEmpresa)clientes[i]).Rut + "\n";
                }
                else if (clientes[i].Departamento == 2)
                {
                    losClientes = "Nombre de Usuario: " + clientes[i].NombreUser + "Mail: " + clientes[i].Mail + "Direccion: " + clientes[i].Direccion + "Interior" + "Fecha de Registro: " + clientes[i].FechaRegistro + " Nombre de la Empresa: " + ((ClienteEmpresa)clientes[i]).NombreEmpresa + " RazonSocial: " + ((ClienteEmpresa)clientes[i]).RazonSocial + " Rut: " + ((ClienteEmpresa)clientes[i]).Rut + "\n";
                }

            }
            return losClientes;
        }

        #endregion
        #region Mostrar Cliente entre fechas
        public List<Cliente> MostrarClientes(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Cliente>losClientes = new List<Cliente>();
            foreach(Cliente cliente in clientes)
            {
                if(cliente.FechaRegistro>=fechaDesde && cliente.FechaRegistro <= fechaHasta)
                {
                    losClientes.Add(cliente);
                }
            }
            return losClientes;
        }
        #endregion
        #region Mostrar Compras
        public string MostrarCompras(DateTime fechaCompra)
        {
            string lasCompras = "";
            for (int i = 0; i < compras.Count; i++)
            {
                if(compras[i].FechaCompra >= fechaCompra)
                {
                    if(compras[i].FormaPago == 1 && compras[i].FormaEntrega == 1)
                    {
                        lasCompras += compras[i].FechaCompra + "- Mail del cliente: " + compras[i].Cliente.Mail + "- Forma de pago: Tarjeta - Forma de Entrega: Domicilio -" + " Productos: " + compras[i].Producto;
                    }
                    else if (compras[i].FormaPago == 2 && compras[i].FormaEntrega == 2)
                    {
                        lasCompras += compras[i].FechaCompra + "- Mail del cliente: " + compras[i].Cliente.Mail + "- Forma de pago: Efectivo contra entrega - Forma de Entrega: Retiro en Pickup -" + " Productos: " + compras[i].Producto;
                    }
                    else if (compras[i].FormaPago == 2 && compras[i].FormaEntrega == 1)
                    {
                        lasCompras += compras[i].FechaCompra + "- Mail del cliente: " + compras[i].Cliente.Mail + "- Forma de pago: Efectivo contra entrega - Forma de Entrega: Domicilio " + " Productos: " + compras[i].Producto;
                    }
                    else if (compras[i].FormaPago == 1 && compras[i].FormaEntrega == 2)
                    {
                        lasCompras += compras[i].FechaCompra + "- Mail del cliente: " + compras[i].Cliente.Mail + "- Forma de pago: Tarjeta - Forma de Entrega: Retiro en Pickup -" + " Productos: " + compras[i].Producto;
                    }
                }
            }
            return lasCompras;
        }
        #endregion
        //(Cliente)
        #region Mostrar todos lo productos
        public string MostrarProductos()
        {
            string losProductos = "";
            for (int i = 0; i < productos.Count; i++)
            {
                losProductos += "Numero Identificador: " + productos[i].Id + " - " + productos[i].NombreProducto + " - " + productos[i].Descripcion + " - Tipo de producto: " + productos[i].Exclusivo + " - Precio: " + productos[i].TipoMoneda + " - " + productos[i].PrecioUnitario + '\n';
            }
            return losProductos;
        }
        #endregion
        #region Producos Filtrado por Categoria
        public string ProductoFiltrado(int filtro)
        {
            string losProductos = "";
            for (int i = 0; i < productos.Count; i++)
            {
                if (filtro == 1)
                {
                    if (productos[i].Categoria == "Frescos")
                    {
                        losProductos += "Numero Identificador: " + productos[i].Id + " " + productos[i].NombreProducto + " - " + productos[i].Descripcion + "Tipo de producto: " + productos[i].Exclusivo + "Precio: $" + productos[i].PrecioUnitario + "\n";
                    }

                }
                else if (filtro == 2)
                {
                    if (productos[i].Categoria == "Congelados")
                    {
                        losProductos += "Numero Identificador: " + productos[i].Id + " " + productos[i].NombreProducto + " - " + productos[i].Descripcion + "Tipo de producto: " + productos[i].Exclusivo + "Precio: $" + productos[i].PrecioUnitario + "\n";
                    }

                }
                else if (filtro == 3)
                {
                    if (productos[i].Categoria == "Hogar")
                    {
                        losProductos += "Numero Identificador: " + productos[i].Id + " " + productos[i].NombreProducto + " - " + productos[i].Descripcion + "Tipo de producto: " + productos[i].Exclusivo + "Precio: $" + productos[i].PrecioUnitario + "\n";
                    }
                }
                else if (filtro == 4)
                {
                    if (productos[i].Categoria == "Textiles")
                    {
                        losProductos += "Numero Identificador: " + productos[i].Id + " " + productos[i].NombreProducto + " - " + productos[i].Descripcion + "Tipo de producto: " + productos[i].Exclusivo + "Precio: $" + productos[i].PrecioUnitario + "\n";
                    }
                }
                else if (filtro == 5)
                {
                    if (productos[i].Categoria == "Tecnologia")
                    {
                        losProductos += "Numero Identificador: " + productos[i].Id + " " + productos[i].NombreProducto + " - " + productos[i].Descripcion + "Tipo de producto: " + productos[i].Exclusivo + "Precio: $" + productos[i].PrecioUnitario + "\n";
                    }
                }
            }
            return losProductos;
        }
        #endregion
        //LOGIN
        /*
        public string Login(string pMail, string pPass)
        {
            string mensaje = "Los campos estan vacios, ingrese su mail y password";
            if (pMail !="" && pPass !="")
            {
                foreach (Cliente cliente in HabiaUnaVez.Instancia.Clientes)
                {
                    if (cliente.Mail == pMail && cliente.Password == pPass)
                    {
                        mensaje = "Bienvenid@" + cliente.NombreUser;
                    }
                }
            }
            else
            {
                mensaje = "Datos incorrectos";
            }
            return mensaje;
        }
        */

        public double TotalAPagar(int idCompra)
        {
            double total = 0;
            if (idCompra > 0)
            {            
                Compra compra = BuscarIdCompra(idCompra);               
                total = compra.Total();
            }
            return total;
        }
        public string ModificarProducto(int id, double precioUnitario)
        {
            string mensaje = "no se cambio el precio";
            Producto producto = BuscarIdProducto(id);
            if(producto != null)
            {
                producto.ModificarDato(precioUnitario);
                mensaje = "El precio se cambio";
            }
            return mensaje;
        }

    }
}
