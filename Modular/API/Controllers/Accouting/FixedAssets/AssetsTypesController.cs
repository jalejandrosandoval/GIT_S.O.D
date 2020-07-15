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
    public class AssetsTypesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public AssetsTypesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/AssetsTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetsType>>> GetAssetsTypes()
        {
            return await _context.AssetsTypes.ToListAsync();
        }

        // GET: api/AssetsTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetsType>> GetAssetsType(int id)
        {
            var assetsType = await _context.AssetsTypes.FindAsync(id);

            if (assetsType == null)
            {
                return NotFound();
            }

            return assetsType;
        }

        // PUT: api/AssetsTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssetsType(int id, AssetsType assetsType)
        {
            if (id != assetsType.Id_AssetsType)
            {
                return BadRequest();
            }

            _context.Entry(assetsType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetsTypeExists(id))
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

        // POST: api/AssetsTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AssetsType>> PostAssetsType(AssetsType assetsType)
        {
            _context.AssetsTypes.Add(assetsType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssetsType", new { id = assetsType.Id_AssetsType }, assetsType);
        }

        // DELETE: api/AssetsTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AssetsType>> DeleteAssetsType(int id)
        {
            var assetsType = await _context.AssetsTypes.FindAsync(id);
            if (assetsType == null)
            {
                return NotFound();
            }

            _context.AssetsTypes.Remove(assetsType);
            await _context.SaveChangesAsync();

            return assetsType;
        }

        private bool AssetsTypeExists(int id)
        {
            return _context.AssetsTypes.Any(e => e.Id_AssetsType == id);
        }
    }
}
