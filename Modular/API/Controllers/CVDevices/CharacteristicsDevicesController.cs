using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models;

namespace API.Controllers.CVDevices
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacteristicsDevicesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CharacteristicsDevicesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/CharacteristicsDevices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacteristicsDevices>>> GetCharacteristicsDevices()
        {
            return await _context.CharacteristicsDevices.ToListAsync();
        }

        // GET: api/CharacteristicsDevices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacteristicsDevices>> GetCharacteristicsDevices(int id)
        {
            var characteristicsDevices = await _context.CharacteristicsDevices.FindAsync(id);

            if (characteristicsDevices == null)
            {
                return NotFound();
            }

            return characteristicsDevices;
        }

        // PUT: api/CharacteristicsDevices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacteristicsDevices(int id, CharacteristicsDevices characteristicsDevices)
        {
            if (id != characteristicsDevices.Id_CharacteristicsDevices)
            {
                return BadRequest();
            }

            _context.Entry(characteristicsDevices).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacteristicsDevicesExists(id))
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

        // POST: api/CharacteristicsDevices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CharacteristicsDevices>> PostCharacteristicsDevices(CharacteristicsDevices characteristicsDevices)
        {
            _context.CharacteristicsDevices.Add(characteristicsDevices);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacteristicsDevices", new { id = characteristicsDevices.Id_CharacteristicsDevices }, characteristicsDevices);
        }

        // DELETE: api/CharacteristicsDevices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacteristicsDevices>> DeleteCharacteristicsDevices(int id)
        {
            var characteristicsDevices = await _context.CharacteristicsDevices.FindAsync(id);
            if (characteristicsDevices == null)
            {
                return NotFound();
            }

            _context.CharacteristicsDevices.Remove(characteristicsDevices);
            await _context.SaveChangesAsync();

            return characteristicsDevices;
        }

        private bool CharacteristicsDevicesExists(int id)
        {
            return _context.CharacteristicsDevices.Any(e => e.Id_CharacteristicsDevices == id);
        }
    }
}
