using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObligatorioDominio;

namespace ProyectoMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginVista()
        {
            return View();
        }
        public ActionResult RecibeDatos(string pMail, string pPass)
        {
            ViewBag.Verifico = "Datos vacios";
            if (pMail != "" && pPass != "")
            {
                if (pMail == "alma@gmail.com" && pPass == "1234")
                {
                    Session["rol"] = "admin";
                    Session["mailUser"] = pMail;
                    ViewBag.Verifico = "Vienvenido" + Session["mailUser"];
                    return RedirectToAction("ClientesXfecha", "Cliente");
                }
                foreach(Cliente cliente in HabiaUnaVez.Instancia.Clientes)
                {
                    if(cliente.Mail == pMail && cliente.Password == pPass)
                    {
                        Session["rol"] = "cliente";
                        Session["mailUser"] = pMail;
                        ViewBag.Verifico = "Vienvenido" + Session["mailUser"];
                        return RedirectToAction("FiltroProducto", "Producto");
                    }
                }
                ViewBag.Verifico = "Datos incorrectos";
            }
            return View("LoginVista");
        }
    }
}