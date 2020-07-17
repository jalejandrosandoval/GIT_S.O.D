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
    public class Devices_AccessoriesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Devices_AccessoriesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Devices_Accessories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Devices_Accessories>>> GetDevices_Accessories()
        {
            return await _context.Devices_Accessories.ToListAsync();
        }

        // GET: api/Devices_Accessories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Devices_Accessories>> GetDevices_Accessories(int id)
        {
            var devices_Accessories = await _context.Devices_Accessories.FindAsync(id);

            if (devices_Accessories == null)
            {
                return NotFound();
            }

            return devices_Accessories;
        }

        // PUT: api/Devices_Accessories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDevices_Accessories(int id, Devices_Accessories devices_Accessories)
        {
            if (id != devices_Accessories.Id_CV_Devices)
            {
                return BadRequest();
            }

            _context.Entry(devices_Accessories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Devices_AccessoriesExists(id))
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

        // POST: api/Devices_Accessories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Devices_Accessories>> PostDevices_Accessories(Devices_Accessories devices_Accessories)
        {
            _context.Devices_Accessories.Add(devices_Accessories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDevices_Accessories", new { id = devices_Accessories.Id_CV_Devices }, devices_Accessories);
        }

        // DELETE: api/Devices_Accessories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Devices_Accessories>> DeleteDevices_Accessories(int id)
        {
            var devices_Accessories = await _context.Devices_Accessories.FindAsync(id);
            if (devices_Accessories == null)
            {
                return NotFound();
            }

            _context.Devices_Accessories.Remove(devices_Accessories);
            await _context.SaveChangesAsync();

            return devices_Accessories;
        }

        private bool Devices_AccessoriesExists(int id)
        {
            return _context.Devices_Accessories.Any(e => e.Id_CV_Devices == id);
        }
    }
}
