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
        public ActionResult Login(string mail, string password)
        {
            ViewBag.Mensaje = "Datos vacios";
            if (mail != "" && password != "")
            {
                foreach (Administrador administrador in Sistema.Instancia.Administradores)
                {
                    if (administrador.Mail == mail && administrador.Password == password)
                    {
                        Session["rol"] = "admin";
                        Session["mailUser"] = mail;
                        ViewBag.Mensaje = "Vienvenido" + administrador.NombreUser;
                        return RedirectToAction("Administradores", "Login");
                    }
                }
                foreach (Cliente cliente in Sistema.Instancia.Clientes)
                {
                    if (cliente.Mail == mail && cliente.Password == password)
                    {
                        Session["rol"] = "cliente";
                        Session["mailUser"] = mail;
                        ViewBag.Mensaje = "Vienvenido" + cliente.NombreUser;
                        return RedirectToAction("Clientes", "Login");
                    }
                }
                ViewBag.Mensaje = "Datos incorrectos";
            }
            return View("Index");
        }
        public ActionResult Administradores()
        {
            return View("Administradores");
        }
        public ActionResult Clientes()
        {
            return View("Clientes");
        }
    }
}