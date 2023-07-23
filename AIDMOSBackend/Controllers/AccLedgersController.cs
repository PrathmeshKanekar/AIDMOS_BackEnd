using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AIDMOSBackend.Context;
using AIDMOS_BackEnd.Models;

namespace AIDMOSBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccLedgersController : ControllerBase
    {
        private readonly ProjectDBContext _context;

        public AccLedgersController(ProjectDBContext context)
        {
            _context = context;
        }

        // GET: api/AccLedgers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccLedger>>> GetAccLedgers()
        {
          if (_context.AccLedgers == null)
          {
              return NotFound();
          }
            return await _context.AccLedgers.ToListAsync();
        }

        // GET: api/AccLedgers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccLedger>> GetAccLedger(decimal id)
        {
          if (_context.AccLedgers == null)
          {
              return NotFound();
          }
            var accLedger = await _context.AccLedgers.FindAsync(id);

            if (accLedger == null)
            {
                return NotFound();
            }

            return accLedger;
        }

        // PUT: api/AccLedgers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccLedger(decimal id, AccLedger accLedger)
        {
            if (id != accLedger.Id)
            {
                return BadRequest();
            }

            _context.Entry(accLedger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccLedgerExists(id))
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

        // POST: api/AccLedgers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccLedger>> PostAccLedger(AccLedger accLedger)
        {
          if (_context.AccLedgers == null)
          {
              return Problem("Entity set 'ProjectDBContext.AccLedgers'  is null.");
          }
            _context.AccLedgers.Add(accLedger);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AccLedgerExists(accLedger.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAccLedger", new { id = accLedger.Id }, accLedger);
        }

        // DELETE: api/AccLedgers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccLedger(decimal id)
        {
            if (_context.AccLedgers == null)
            {
                return NotFound();
            }
            var accLedger = await _context.AccLedgers.FindAsync(id);
            if (accLedger == null)
            {
                return NotFound();
            }

            _context.AccLedgers.Remove(accLedger);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccLedgerExists(decimal id)
        {
            return (_context.AccLedgers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
