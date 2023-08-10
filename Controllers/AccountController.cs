using Farmacia.DatosDB;
using Farmacia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Farmacia.Controllers
{
    public class AccountController : Controller
    {
        private FarmaciaContext _context;

        public AccountController(FarmaciaContext context)
        {
            _context = context;
        }

        [HttpGet]
        //METODO PARA QUE MUESTRE EL FORMULARIO DE LOGIN
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ClienteModel cliente)
        {
            if (!String.IsNullOrEmpty(cliente.Correo.ToString()) && (!String.IsNullOrEmpty(cliente.Clave.ToString())))
            {
                var cor = _context.Cliente.SingleOrDefault(c =>
                c.Correo == cliente.Correo
                &&
                c.Clave == cliente.Clave
                );
                if (cor != null)
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.AlertMessage = "No se encuentra la persona ingresada";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}
