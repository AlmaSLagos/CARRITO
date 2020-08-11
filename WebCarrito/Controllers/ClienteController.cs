using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioCarrito;

namespace WebCarrito.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult AltaComun()
        {
            return View();
        }
        public ActionResult X(string mail, string direccion, string nombreUser, int? departamento, DateTime? fechaRegistro, string password, string nombre, int? cedula)
        {
            if (mail != "" && direccion != "" && nombreUser != "" && departamento != null && fechaRegistro != null && password != null && nombre != "" && cedula != null)
            {
                ViewBag.Mensaje = Sistema.Instancia.AltaClienteComun(mail, direccion, nombreUser, (int)departamento, (DateTime)fechaRegistro, password, nombre, (int)cedula);
            }
            return View("AltaComun");
        }
        public ActionResult AltaEmpresa()
        {
            return View();
        }
        public ActionResult Y(string mail, string direccion, string nombreUser, int? departamento, DateTime? fechaRegistro, string password, string nombreEmpresa, string razonSocial, int? rut)
        {
            if (mail != "" && direccion != "" && nombreUser != "" && departamento != null && fechaRegistro != null && password != null && nombreEmpresa != "" && razonSocial != "" && rut != null)
            {
                ViewBag.Mensaje = Sistema.Instancia.AltaClienteEmpresa(mail, direccion, nombreUser, (int)departamento, (DateTime)fechaRegistro, password, nombreEmpresa, razonSocial, (int)rut);
            }
            return View("AltaEmpresa");
        }

    }
}