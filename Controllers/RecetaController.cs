using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class RecetaController : Controller
    {
        private FarmaciaContext _context;

        public RecetaController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var receta = _context.Receta.FirstOrDefault();
            return View(receta);
        }

        public IActionResult MultiIndex()
        {
            var ListaReceta = _context.Receta.ToList();
            return View("MultiReceta", ListaReceta);
        }
    }
}
