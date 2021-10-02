﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VentaAviones.Data;
using VentaAviones.Models;

namespace VentaAviones
{
    public class AvionsController : Controller
    {
        private readonly VentaAvionesContext _context;

        public AvionsController(VentaAvionesContext context)
        {
            _context = context;
        }

        // GET: Avions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Avion.ToListAsync());
        }

        // GET: Avions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avion == null)
            {
                return NotFound();
            }

            return View(avion);
        }

        // GET: Avions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Avions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Tamano,Pasajeros,Color,Turbinas")] Avion avion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(avion);
        }

        // GET: Avions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion.FindAsync(id);
            if (avion == null)
            {
                return NotFound();
            }
            return View(avion);
        }

        // POST: Avions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Tamano,Pasajeros,Color,Turbinas")] Avion avion)
        {
            if (id != avion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvionExists(avion.Id))
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
            return View(avion);
        }

        // GET: Avions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avion == null)
            {
                return NotFound();
            }

            return View(avion);
        }

        // POST: Avions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avion = await _context.Avion.FindAsync(id);
            _context.Avion.Remove(avion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvionExists(int id)
        {
            return _context.Avion.Any(e => e.Id == id);
        }
    }
}
