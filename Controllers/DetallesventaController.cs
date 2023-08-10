using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class DetallesventaController : Controller
    {
        private FarmaciaContext _context;

        public DetallesventaController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var detallesventa = _context.Detallesventa.FirstOrDefault();
            return View(detallesventa);
        }

        public IActionResult MultiIndex()
        {
            var ListaDetallesventa = _context.Detallesventa.ToList();
            return View("MultiDetallesventa", ListaDetallesventa);
        }
    }
}
