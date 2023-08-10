using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class ProveedorController : Controller
    {
        private FarmaciaContext _context;

        public ProveedorController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var proveedor = _context.Proveedor.FirstOrDefault();
            return View(proveedor);
        }

        public IActionResult MultiIndex()
        {
            var ListaProveedor = _context.Proveedor.ToList();
            return View("MultiProveedor", ListaProveedor);
        }
    }
}
