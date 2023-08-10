using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.DatosDB;
using Farmacia.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Controllers
{
    public class MedicamentoController : Controller
    {
        private readonly FarmaciaContext _context;

        public MedicamentoController(FarmaciaContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return _context.Medicamento != null ?
                        View(await _context.Medicamento.ToListAsync()) :
                        Problem("Entity set 'FarmaciaContext.Medicamento'  is null.");
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Medicamento == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamento
                .FirstOrDefaultAsync(m => m.medicamentoId == id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return View(medicamento);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
            Create([Bind("Id, Nombre, Descripcion, Stock, FechaCreacion")] MedicamentoModel medicamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicamento);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Medicamento == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamento.FindAsync(id);
            if (medicamento == null)
            {
                return NotFound();
            }
            return View(medicamento);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Nombre, Descripcion, Stock, FechaCreacion")] MedicamentoModel medicamento)
        {
            if (id != medicamento.medicamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicamentoExists(medicamento.medicamentoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicamento);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Medicamento == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamento
                .FirstOrDefaultAsync(m => m.medicamentoId == id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return View(medicamento);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Medicamento == null)
            {
                return Problem("Entity set 'FarmaciaContext.Medicamento'  is null.");
            }
            var medicamento = await _context.Medicamento.FindAsync(id);
            if (medicamento != null)
            {
                _context.Medicamento.Remove(medicamento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicamentoExists(int id)
        {
            return (_context.Medicamento?.Any(e => e.medicamentoId == id)).GetValueOrDefault();
        }
    }
}
