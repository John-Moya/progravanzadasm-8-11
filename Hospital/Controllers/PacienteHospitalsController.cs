using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital.Data;
using Hospital.Models;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteHospitalsController : ControllerBase
    {
        private readonly HospitalContext _context;

        public PacienteHospitalsController(HospitalContext context)
        {
            _context = context;
        }

        // GET: api/PacienteHospitals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PacienteHospital>>> GetPacienteHospital()
        {
            return await _context.PacienteHospital.ToListAsync();
        }

        // GET: api/PacienteHospitals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteHospital>> GetPacienteHospital(int id)
        {
            var pacienteHospital = await _context.PacienteHospital.FindAsync(id);

            if (pacienteHospital == null)
            {
                return NotFound();
            }

            return pacienteHospital;
        }

        // PUT: api/PacienteHospitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPacienteHospital(int id, PacienteHospital pacienteHospital)
        {
            if (id != pacienteHospital.Id)
            {
                return BadRequest();
            }

            _context.Entry(pacienteHospital).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacienteHospitalExists(id))
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

        // POST: api/PacienteHospitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PacienteHospital>> PostPacienteHospital(PacienteHospital pacienteHospital)
        {
            _context.PacienteHospital.Add(pacienteHospital);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPacienteHospital", new { id = pacienteHospital.Id }, pacienteHospital);
        }

        // DELETE: api/PacienteHospitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePacienteHospital(int id)
        {
            var pacienteHospital = await _context.PacienteHospital.FindAsync(id);
            if (pacienteHospital == null)
            {
                return NotFound();
            }

            _context.PacienteHospital.Remove(pacienteHospital);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PacienteHospitalExists(int id)
        {
            return _context.PacienteHospital.Any(e => e.Id == id);
        }
    }
}
