using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_GiangVien.Models;

namespace API_GiangVien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiodaysController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public GiodaysController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Giodays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gioday>>> GetGioday()
        {
            return await _context.Gioday.ToListAsync();
        }

        // GET: api/Giodays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gioday>> GetGioday(int id)
        {
            var gioday = await _context.Gioday.FindAsync(id);

            if (gioday == null)
            {
                return NotFound();
            }

            return gioday;
        }

        // PUT: api/Giodays/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGioday(int id, Gioday gioday)
        {
            if (id != gioday.MaGd)
            {
                return BadRequest();
            }

            _context.Entry(gioday).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GiodayExists(id))
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

        // POST: api/Giodays
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Gioday>> PostGioday(Gioday gioday)
        {
            _context.Gioday.Add(gioday);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGioday", new { id = gioday.MaGd }, gioday);
        }

        // DELETE: api/Giodays/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gioday>> DeleteGioday(int id)
        {
            var gioday = await _context.Gioday.FindAsync(id);
            if (gioday == null)
            {
                return NotFound();
            }

            _context.Gioday.Remove(gioday);
            await _context.SaveChangesAsync();

            return gioday;
        }

        private bool GiodayExists(int id)
        {
            return _context.Gioday.Any(e => e.MaGd == id);
        }
    }
}
