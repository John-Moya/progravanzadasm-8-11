using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Automotores.Data;
using Automotores.Models;
using Microsoft.AspNetCore.Authorization;

namespace Automotores.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiciosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Servicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Servicios.ToListAsync());
        }

        // GET: Servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicios = await _context.Servicios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicios == null)
            {
                return NotFound();
            }

            return View(servicios);
        }
        [Authorize]
        // GET: Servicios/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        // POST: Servicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Servicio,Costo")] Servicios servicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicios);
        }
        [Authorize]
        // GET: Servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicios = await _context.Servicios.FindAsync(id);
            if (servicios == null)
            {
                return NotFound();
            }
            return View(servicios);
        }
        [Authorize]
        // POST: Servicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Servicio,Costo")] Servicios servicios)
        {
            if (id != servicios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiciosExists(servicios.Id))
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
            return View(servicios);
        }
        [Authorize]
        // GET: Servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicios = await _context.Servicios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicios == null)
            {
                return NotFound();
            }

            return View(servicios);
        }
        [Authorize]
        // POST: Servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicios = await _context.Servicios.FindAsync(id);
            _context.Servicios.Remove(servicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiciosExists(int id)
        {
            return _context.Servicios.Any(e => e.Id == id);
        }
    }
}
