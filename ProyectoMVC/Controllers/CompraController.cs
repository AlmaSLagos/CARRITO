using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObligatorioDominio;

namespace ProyectoMVC.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult DatosCompra()
        {
            return View();
        }
        public ActionResult RecibeDatos(int ? formaPago, int ? formaEntrega, DateTime fechaCompra, string cliente)
        {
            ViewBag.Mensaje = HabiaUnaVez.Instancia.AltaCompra((int)formaPago, (int)formaEntrega, fechaCompra, cliente);
            return View("DatosCompra");
        }
        public ActionResult Carrito()
        {
            return View();
        }
        public ActionResult ProducEnElCarrito(int idProducto, double ? cantidad, int idCompra)
        {
         //   HabiaUnaVez.Instancia.AltaUnaCompra((int)idProducto, (double)cantidad, (int) idCompra);
            ViewBag.Verificar = HabiaUnaVez.Instancia.AltaUnaCompra(idProducto, (double) cantidad, idCompra);
           // HabiaUnaVez.Instancia.TotalAPagar((int)idCompra);
            ViewBag.Total= "El monto a pagar es: " + HabiaUnaVez.Instancia.TotalAPagar(idCompra);
            return View("Carrito");
        }
        public ActionResult TerminarCompra(int idCompra)
        {
            ViewBag.Finalizada = HabiaUnaVez.Instancia.TerminarCompra(idCompra);
            return View("Carrito");
        }
    }
}