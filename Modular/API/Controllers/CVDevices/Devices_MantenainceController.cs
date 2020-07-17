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
    public class Devices_MantenainceController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Devices_MantenainceController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Devices_Mantenaince
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Devices_Mantenaince>>> GetDevices_Mantenaince()
        {
            return await _context.Devices_Mantenaince.ToListAsync();
        }

        // GET: api/Devices_Mantenaince/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Devices_Mantenaince>> GetDevices_Mantenaince(int id)
        {
            var devices_Mantenaince = await _context.Devices_Mantenaince.FindAsync(id);

            if (devices_Mantenaince == null)
            {
                return NotFound();
            }

            return devices_Mantenaince;
        }

        // PUT: api/Devices_Mantenaince/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDevices_Mantenaince(int id, Devices_Mantenaince devices_Mantenaince)
        {
            if (id != devices_Mantenaince.Id_DevicesMantenaince)
            {
                return BadRequest();
            }

            _context.Entry(devices_Mantenaince).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Devices_MantenainceExists(id))
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

        // POST: api/Devices_Mantenaince
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Devices_Mantenaince>> PostDevices_Mantenaince(Devices_Mantenaince devices_Mantenaince)
        {
            _context.Devices_Mantenaince.Add(devices_Mantenaince);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDevices_Mantenaince", new { id = devices_Mantenaince.Id_DevicesMantenaince }, devices_Mantenaince);
        }

        // DELETE: api/Devices_Mantenaince/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Devices_Mantenaince>> DeleteDevices_Mantenaince(int id)
        {
            var devices_Mantenaince = await _context.Devices_Mantenaince.FindAsync(id);
            if (devices_Mantenaince == null)
            {
                return NotFound();
            }

            _context.Devices_Mantenaince.Remove(devices_Mantenaince);
            await _context.SaveChangesAsync();

            return devices_Mantenaince;
        }

        private bool Devices_MantenainceExists(int id)
        {
            return _context.Devices_Mantenaince.Any(e => e.Id_DevicesMantenaince == id);
        }
    }
}
