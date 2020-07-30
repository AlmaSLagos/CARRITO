using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObligatorioDominio;

namespace ProyectoMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ElAltaProducto()
        {
            return View();
        }
        public ActionResult AltaProduc(string nombreProducto, string descripcion, string exclusivo, string categoria, double ? precioUnitario, string tipoMoneda)
        {         
            ViewBag.AltaProductOk = HabiaUnaVez.Instancia.AltaProducto(nombreProducto, descripcion, exclusivo, categoria, (double) precioUnitario, tipoMoneda);
            return View("ElAltaProducto");
        }
        public ActionResult VerProductos()
        {
            ViewBag.MostrarProductos = HabiaUnaVez.Instancia.MostrarProductos();
            return View();
        }
        public ActionResult FiltroProducto()
        {
            return View();
        }
        public ActionResult MostrarFiltrado(int ? filtro)
        {
            ViewBag.Categoria= HabiaUnaVez.Instancia.ProductoFiltrado((int)filtro);
            return View("FiltroProducto");
        } 
        public ActionResult ModificarPrecio(int id, double ? precioUnitario)
        {
            ViewBag.Precio = HabiaUnaVez.Instancia.ModificarProducto(id, (double) precioUnitario);
            return View("VerProductos");
        }
    }
    
}