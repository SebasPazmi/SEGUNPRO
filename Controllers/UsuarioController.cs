using Farmacia.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class UsuarioController : Controller
    {
        private FarmaciaContext _context;

        public UsuarioController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var usuario = _context.Usuario.FirstOrDefault();
            return View(usuario);
        }

        public IActionResult MultiIndex()
        {
            var ListaUsuario = _context.Usuario.ToList();
            return View("MultiUsuario", ListaUsuario);
        }
    }
}
