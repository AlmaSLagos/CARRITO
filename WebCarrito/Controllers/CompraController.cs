using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioCarrito;

namespace WebCarrito.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult DatosCompra()
        {
            return View();
        }
        public ActionResult RecibeDatos(int? formaPago, int? formaEntrega, DateTime? fechaCompra, string cliente)
        {
            if (formaPago != null && formaEntrega != null && fechaCompra != null && cliente != "")
            {
                ViewBag.Mensaje = Sistema.Instancia.AltaCompra((int)formaPago, (int)formaEntrega, (DateTime)fechaCompra, cliente);
            }
            return View("DatosCompra");
        }
        public ActionResult Carrito()
        {
            return View();
        }
        public ActionResult ProducEnElCarrito(int? idProducto, double? cantidad, int? idCompra, double? valorDolar)
        {
            if (idProducto != null && cantidad != null && idCompra != null && valorDolar != null)
            {
                ViewBag.Verificar = Sistema.Instancia.AltaUnaCompra((int)idProducto, (double)cantidad, (int)idCompra);
                ViewBag.Total = "El monto a pagar es: " + Sistema.Instancia.TotalAPagar((int)idCompra, (double)valorDolar);
            }
            return View("Carrito");
        }
        public ActionResult TerminarCompra(int? idCompra)
        {
            if (idCompra != null)
            {
                ViewBag.Finalizada = Sistema.Instancia.TerminarCompra((int)idCompra);
            }
            return View("Carrito");
        }
    }
}