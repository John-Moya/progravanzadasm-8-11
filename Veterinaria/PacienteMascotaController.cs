using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria
{
    public class PacienteMascotaController : Controller
    {
        private readonly VeterinariaContext _context;

        public PacienteMascotaController(VeterinariaContext context)
        {
            _context = context;
        }

        // GET: PacienteMascota
        public async Task<IActionResult> Index()
        {
            return View(await _context.PacienteMascota.ToListAsync());
        }

        // GET: PacienteMascota/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacienteMascota = await _context.PacienteMascota
                .FirstOrDefaultAsync(m => m.id == id);
            if (pacienteMascota == null)
            {
                return NotFound();
            }

            return View(pacienteMascota);
        }

        // GET: PacienteMascota/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PacienteMascota/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,NombreMascota,Raza,FechaNacimientoMascota,NombreDueno,Telefono,Direccion,Correo,Cedula")] PacienteMascota pacienteMascota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacienteMascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pacienteMascota);
        }

        // GET: PacienteMascota/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacienteMascota = await _context.PacienteMascota.FindAsync(id);
            if (pacienteMascota == null)
            {
                return NotFound();
            }
            return View(pacienteMascota);
        }

        // POST: PacienteMascota/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,NombreMascota,Raza,FechaNacimientoMascota,NombreDueno,Telefono,Direccion,Correo,Cedula")] PacienteMascota pacienteMascota)
        {
            if (id != pacienteMascota.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacienteMascota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteMascotaExists(pacienteMascota.id))
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
            return View(pacienteMascota);
        }

        // GET: PacienteMascota/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacienteMascota = await _context.PacienteMascota
                .FirstOrDefaultAsync(m => m.id == id);
            if (pacienteMascota == null)
            {
                return NotFound();
            }

            return View(pacienteMascota);
        }

        // POST: PacienteMascota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pacienteMascota = await _context.PacienteMascota.FindAsync(id);
            _context.PacienteMascota.Remove(pacienteMascota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteMascotaExists(int id)
        {
            return _context.PacienteMascota.Any(e => e.id == id);
        }
    }
}
