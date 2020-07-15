using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models;

namespace API.Controllers.Accouting.FixedAssets
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixedAssetsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public FixedAssetsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Fixed_Assets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fixed_Assets>>> GetFixed_Assets()
        {
            return await _context.Fixed_Assets.ToListAsync();
        }

        // GET: api/Fixed_Assets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fixed_Assets>> GetFixed_Assets(int id)
        {
            var fixed_Assets = await _context.Fixed_Assets.FindAsync(id);

            if (fixed_Assets == null)
            {
                return NotFound();
            }

            return fixed_Assets;
        }

        // PUT: api/Fixed_Assets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFixed_Assets(int id, Fixed_Assets fixed_Assets)
        {
            if (id != fixed_Assets.Id_Fixed_Assests)
            {
                return BadRequest();
            }

            _context.Entry(fixed_Assets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Fixed_AssetsExists(id))
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

        // POST: api/Fixed_Assets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Fixed_Assets>> PostFixed_Assets(Fixed_Assets fixed_Assets)
        {
            _context.Fixed_Assets.Add(fixed_Assets);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFixed_Assets", new { id = fixed_Assets.Id_Fixed_Assests }, fixed_Assets);
        }

        // DELETE: api/Fixed_Assets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fixed_Assets>> DeleteFixed_Assets(int id)
        {
            var fixed_Assets = await _context.Fixed_Assets.FindAsync(id);
            if (fixed_Assets == null)
            {
                return NotFound();
            }

            _context.Fixed_Assets.Remove(fixed_Assets);
            await _context.SaveChangesAsync();

            return fixed_Assets;
        }

        private bool Fixed_AssetsExists(int id)
        {
            return _context.Fixed_Assets.Any(e => e.Id_Fixed_Assests == id);
        }
    }
}
