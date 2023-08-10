using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class SucursalController : Controller
    {
        private FarmaciaContext _context;

        public SucursalController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sucursal = _context.Sucursal.FirstOrDefault();
            return View(sucursal);
        }

        public IActionResult MultiIndex()
        {
            var ListaSucursal = _context.Sucursal.ToList();
            return View("MultiSucursal", ListaSucursal);
        }
    }
}
