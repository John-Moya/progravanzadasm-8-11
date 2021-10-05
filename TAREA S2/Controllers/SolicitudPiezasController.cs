using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tareaS1.Data;
using tareaS1.Models;

namespace tareaS1.Controllers
{
    public class SolicitudPiezasController : Controller
    {
        private readonly tareaS1Context _context;

        public SolicitudPiezasController(tareaS1Context context)
        {
            _context = context;
        }

        // GET: SolicitudPiezas
        public async Task<IActionResult> Index()
        {
            return View(await _context.SolicitudPiezas.ToListAsync());
        }

        // GET: SolicitudPiezas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPiezas = await _context.SolicitudPiezas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPiezas == null)
            {
                return NotFound();
            }

            return View(solicitudPiezas);
        }

        // GET: SolicitudPiezas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SolicitudPiezas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Direccion,Repuesto,Marca,Anio,Cantidad")] SolicitudPiezas solicitudPiezas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudPiezas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitudPiezas);
        }

        // GET: SolicitudPiezas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPiezas = await _context.SolicitudPiezas.FindAsync(id);
            if (solicitudPiezas == null)
            {
                return NotFound();
            }
            return View(solicitudPiezas);
        }

        // POST: SolicitudPiezas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Direccion,Repuesto,Marca,Anio,Cantidad")] SolicitudPiezas solicitudPiezas)
        {
            if (id != solicitudPiezas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudPiezas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudPiezasExists(solicitudPiezas.Id))
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
            return View(solicitudPiezas);
        }

        // GET: SolicitudPiezas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPiezas = await _context.SolicitudPiezas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPiezas == null)
            {
                return NotFound();
            }

            return View(solicitudPiezas);
        }

        // POST: SolicitudPiezas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitudPiezas = await _context.SolicitudPiezas.FindAsync(id);
            _context.SolicitudPiezas.Remove(solicitudPiezas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudPiezasExists(int id)
        {
            return _context.SolicitudPiezas.Any(e => e.Id == id);
        }
    }
}
