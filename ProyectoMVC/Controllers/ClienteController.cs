 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObligatorioDominio;

namespace ProyectoMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult AltaClienteComunVista()
        {
            return View();
        }
        public ActionResult AltaComun(string mail, string direccion, string nombreUser, int ? departamento, DateTime fechaRegistro, string password, string nombre, string cedula, string celular)
        {
            ViewBag.AltaClienteComun = HabiaUnaVez.Instancia.AltaClienteEmpresa(mail, direccion, nombreUser, (int)departamento, fechaRegistro, password, nombre, cedula, celular);
            return View();
        }
        public ActionResult IndexAltaEmpresa() 
        {
            return View("AltaClienteEmpresaVista");
        }
        public ActionResult AltaEmpresa(string mail, string direccion, string nombreUser, int ? departamento, DateTime fechaRegistro, string password, string nombreEmpresa, string razonSocial, string rut)
        {          
            ViewBag.AltaClienteEmpresa = HabiaUnaVez.Instancia.AltaClienteEmpresa(mail, direccion, nombreUser, (int)departamento, fechaRegistro, password, nombreEmpresa, razonSocial, rut);
            return View();
        }
        public ActionResult MostrarClientes()
        {
            ViewBag.MostrarComun = HabiaUnaVez.Instancia.MostrarClientesComunes();
            return View("MostrarClientes");
        }
        public ActionResult MostrarEmpresas()
        {
            ViewBag.MostrarEmpresa = HabiaUnaVez.Instancia.MostrarClientesEmpresas();
            return View("MostrarEmpresas");
        }
        public ActionResult ClientesXfecha()
        {
            return View();
        }
        public ActionResult PasarFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            ViewBag.MostrarPorFecha = HabiaUnaVez.Instancia.MostrarClientes(fechaDesde, fechaHasta);
            return View("ClientesXfecha");
        }
        
        
       
    }
}