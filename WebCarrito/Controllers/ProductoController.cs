using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioCarrito;

namespace WebCarrito.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult AltaProducto()
        {
            return View();
        }
        public ActionResult X(string nombreProducto, string descripcion, string categoria, double? precio, string tipoMoneda)
        {
            if (nombreProducto != "" && descripcion != "" && categoria != "" && precio != null && tipoMoneda != "")
            {
                ViewBag.Mensaje = Sistema.Instancia.AltaProducto(nombreProducto, descripcion, categoria, (double)precio, tipoMoneda);
            }
            return View("AltaProducto");
        }
        public ActionResult Y(int? id, double? presioUnitario, string tipoMoneda)
        {
            if (id != null && presioUnitario != null && tipoMoneda != "")
            {
                ViewBag.MensajesDos = Sistema.Instancia.ModificarProducto((int)id,(double)presioUnitario, tipoMoneda);
            }
            return View("AltaProducto");
        }
    }
}