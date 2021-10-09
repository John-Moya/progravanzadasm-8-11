using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria
{
    public class vetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public vetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: vets
        [AllowAnonymous]
        public IActionResult Start()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Services()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Contacto()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Veterinaria.ToListAsync());
        }

        // GET: vets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vet = await _context.Veterinaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vet == null)
            {
                return NotFound();
            }

            return View(vet);
        }

        // GET: vets/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: vets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Telefono,Correo,Mascota,Servicio")] vet vet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vet);
        }

        // GET: vets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vet = await _context.Veterinaria.FindAsync(id);
            if (vet == null)
            {
                return NotFound();
            }
            return View(vet);
        }

        // POST: vets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Telefono,Correo,Mascota,Servicio")] vet vet)
        {
            if (id != vet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!vetExists(vet.Id))
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
            return View(vet);
        }

        // GET: vets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vet = await _context.Veterinaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vet == null)
            {
                return NotFound();
            }

            return View(vet);
        }

        // POST: vets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vet = await _context.Veterinaria.FindAsync(id);
            _context.Veterinaria.Remove(vet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool vetExists(int id)
        {
            return _context.Veterinaria.Any(e => e.Id == id);
        }
    }
}
