using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Reconnect.Context;
using API_Reconnect.Models;

namespace API_Reconnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaleConoscoController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public FaleConoscoController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/FaleConosco
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaleConosco>>> GetFaleConosco()
        {
            return await _context.FaleConosco.ToListAsync();
        }

        // GET: api/FaleConosco/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FaleConosco>> GetFaleConosco(int id)
        {
            var faleConosco = await _context.FaleConosco.FindAsync(id);

            if (faleConosco == null)
            {
                return NotFound();
            }

            return faleConosco;
        }

        // PUT: api/FaleConosco/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaleConosco(int id, FaleConosco faleConosco)
        {
            if (id != faleConosco.Id)
            {
                return BadRequest();
            }

            _context.Entry(faleConosco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaleConoscoExists(id))
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

        // POST: api/FaleConosco
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FaleConosco>> PostFaleConosco(FaleConosco faleConosco)
        {
            _context.FaleConosco.Add(faleConosco);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaleConosco", new { id = faleConosco.Id }, faleConosco);
        }

        // DELETE: api/FaleConosco/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaleConosco(int id)
        {
            var faleConosco = await _context.FaleConosco.FindAsync(id);
            if (faleConosco == null)
            {
                return NotFound();
            }

            _context.FaleConosco.Remove(faleConosco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaleConoscoExists(int id)
        {
            return _context.FaleConosco.Any(e => e.Id == id);
        }
    }
}
