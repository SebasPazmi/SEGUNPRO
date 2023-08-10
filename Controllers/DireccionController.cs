using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class DireccionController : Controller
    {
        private FarmaciaContext _context;

        public DireccionController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var direccion = _context.Direccion.FirstOrDefault();
            return View(direccion);
        }

        public IActionResult MultiIndex()
        {
            var ListaDireccion = _context.Direccion.ToList();
            return View("MultiDireccion", ListaDireccion);
        }
    }
}
