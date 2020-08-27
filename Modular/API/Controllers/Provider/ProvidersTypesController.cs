using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models.Providers;

namespace API.Controllers.Provider
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersTypesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ProvidersTypesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/ProviderTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvidersType>>> GetProvidersType()
        {
            return await _context.ProvidersType.ToListAsync();
        }

        // GET: api/ProviderTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProvidersType>> GetProviderType(int id)
        {
            var providerType = await _context.ProvidersType.FindAsync(id);

            if (providerType == null)
            {
                return NotFound();
            }

            return providerType;
        }

        // PUT: api/ProviderTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProviderType(int id, ProvidersType providerType)
        {
            if (id != providerType.Id_ProviderType)
            {
                return BadRequest();
            }

            _context.Entry(providerType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderTypeExists(id))
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

        // POST: api/ProviderTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProvidersType>> PostProviderType(ProvidersType providerType)
        {
            _context.ProvidersType.Add(providerType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProviderType", new { id = providerType.Id_ProviderType }, providerType);
        }

        // DELETE: api/ProviderTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProvidersType>> DeleteProviderType(int id)
        {
            var providerType = await _context.ProvidersType.FindAsync(id);
            if (providerType == null)
            {
                return NotFound();
            }

            _context.ProvidersType.Remove(providerType);
            await _context.SaveChangesAsync();

            return providerType;
        }

        private bool ProviderTypeExists(int id)
        {
            return _context.ProvidersType.Any(e => e.Id_ProviderType == id);
        }
    }
}
