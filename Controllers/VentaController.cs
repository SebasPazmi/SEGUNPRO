using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class VentaController : Controller
    {
        private FarmaciaContext _context;

        public VentaController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var venta = _context.Venta.FirstOrDefault();
            return View(venta);
        }

        public IActionResult MultiIndex()
        {
            var ListaVenta = _context.Venta.ToList();
            return View("MultiVenta", ListaVenta);
        }
    }
}
