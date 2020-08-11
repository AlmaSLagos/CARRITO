using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioCarrito;

namespace WebCarrito.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AltaAdmin()
        {
            return View();
        }
        public ActionResult X(string mail, string password, string nombreUser)
        {
            if (mail != "" && password != "" && nombreUser != "")
            {
                ViewBag.Mensaje = Sistema.Instancia.AltaAdmin(mail, password, nombreUser);
            }          
            return View("AltaAdmin");
        }
    }
}