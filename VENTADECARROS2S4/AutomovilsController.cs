using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VENTADECARROS2S4.Data;
using VENTADECARROS2S4.MODELOS;

namespace VENTADECARROS2S4
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomovilsController : ControllerBase
    {
        private readonly VENTADECARROS2S4Context _context;

        public AutomovilsController(VENTADECARROS2S4Context context)
        {
            _context = context;
        }

        // GET: api/Automovils
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Automovil>>> GetAutomovil()
        {
            return await _context.Automovil.ToListAsync();
        }

        // GET: api/Automovils/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Automovil>> GetAutomovil(int id)
        {
            var automovil = await _context.Automovil.FindAsync(id);

            if (automovil == null)
            {
                return NotFound();
            }

            return automovil;
        }

        // PUT: api/Automovils/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutomovil(int id, Automovil automovil)
        {
            if (id != automovil.Id)
            {
                return BadRequest();
            }

            _context.Entry(automovil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovilExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Automovils
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Automovil>> PostAutomovil(Automovil automovil)
        {
            _context.Automovil.Add(automovil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutomovil", new { id = automovil.Id }, automovil);
        }

        // DELETE: api/Automovils/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutomovil(int id)
        {
            var automovil = await _context.Automovil.FindAsync(id);
            if (automovil == null)
            {
                return NotFound();
            }

            _context.Automovil.Remove(automovil);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutomovilExists(int id)
        {
            return _context.Automovil.Any(e => e.Id == id);
        }
    }
}
