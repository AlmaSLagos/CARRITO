using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioCarrito;

namespace WebCarrito.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        /*
        public ActionResult Login(string mail, string password)
        {
            if (mail != "" && password != "")
            {
                ViewBag.Mensaje = Sistema.Instancia.Login(mail, password);
            }
            return View("Index");
        }
        */
    }
}