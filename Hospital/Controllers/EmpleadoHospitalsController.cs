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
    public class EmpleadoHospitalsController : ControllerBase
    {
        private readonly HospitalContext _context;

        public EmpleadoHospitalsController(HospitalContext context)
        {
            _context = context;
        }

        // GET: api/EmpleadoHospitals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpleadoHospital>>> GetEmpleadoHospital()
        {
            return await _context.EmpleadoHospital.ToListAsync();
        }

        // GET: api/EmpleadoHospitals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpleadoHospital>> GetEmpleadoHospital(int id)
        {
            var empleadoHospital = await _context.EmpleadoHospital.FindAsync(id);

            if (empleadoHospital == null)
            {
                return NotFound();
            }

            return empleadoHospital;
        }

        // PUT: api/EmpleadoHospitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleadoHospital(int id, EmpleadoHospital empleadoHospital)
        {
            if (id != empleadoHospital.Id)
            {
                return BadRequest();
            }

            _context.Entry(empleadoHospital).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoHospitalExists(id))
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

        // POST: api/EmpleadoHospitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpleadoHospital>> PostEmpleadoHospital(EmpleadoHospital empleadoHospital)
        {
            _context.EmpleadoHospital.Add(empleadoHospital);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleadoHospital", new { id = empleadoHospital.Id }, empleadoHospital);
        }

        // DELETE: api/EmpleadoHospitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleadoHospital(int id)
        {
            var empleadoHospital = await _context.EmpleadoHospital.FindAsync(id);
            if (empleadoHospital == null)
            {
                return NotFound();
            }

            _context.EmpleadoHospital.Remove(empleadoHospital);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadoHospitalExists(int id)
        {
            return _context.EmpleadoHospital.Any(e => e.Id == id);
        }
    }
}
