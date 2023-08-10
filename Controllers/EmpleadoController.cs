using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class EmpleadoController : Controller
    {
        private FarmaciaContext _context;

        public EmpleadoController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var empleado = _context.Empleado.FirstOrDefault();
            return View(empleado);
        }

        public IActionResult MultiIndex()
        {
            var ListaEmpleado = _context.Empleado.ToList();
            return View("MultiEmpleado", ListaEmpleado);
        }
    }
}
