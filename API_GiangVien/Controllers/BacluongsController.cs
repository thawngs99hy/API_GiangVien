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
    public class BacluongsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public BacluongsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Bacluongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bacluong>>> GetBacluong()
        {
            return await _context.Bacluong.ToListAsync();
        }

        // GET: api/Bacluongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bacluong>> GetBacluong(int id)
        {
            var bacluong = await _context.Bacluong.FindAsync(id);

            if (bacluong == null)
            {
                return NotFound();
            }

            return bacluong;
        }

        // PUT: api/Bacluongs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBacluong(int id, Bacluong bacluong)
        {
            if (id != bacluong.MaBac)
            {
                return BadRequest();
            }

            _context.Entry(bacluong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BacluongExists(id))
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

        // POST: api/Bacluongs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Bacluong>> PostBacluong(Bacluong bacluong)
        {
            _context.Bacluong.Add(bacluong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBacluong", new { id = bacluong.MaBac }, bacluong);
        }

        // DELETE: api/Bacluongs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bacluong>> DeleteBacluong(int id)
        {
            var bacluong = await _context.Bacluong.FindAsync(id);
            if (bacluong == null)
            {
                return NotFound();
            }

            _context.Bacluong.Remove(bacluong);
            await _context.SaveChangesAsync();

            return bacluong;
        }

        private bool BacluongExists(int id)
        {
            return _context.Bacluong.Any(e => e.MaBac == id);
        }
    }
}
