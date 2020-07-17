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
    public class CV_DevicesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CV_DevicesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/CV_Devices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CV_Devices>>> GetCV_Devices()
        {
            return await _context.CV_Devices.ToListAsync();
        }

        // GET: api/CV_Devices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CV_Devices>> GetCV_Devices(int id)
        {
            var cV_Devices = await _context.CV_Devices.FindAsync(id);

            if (cV_Devices == null)
            {
                return NotFound();
            }

            return cV_Devices;
        }

        // PUT: api/CV_Devices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCV_Devices(int id, CV_Devices cV_Devices)
        {
            if (id != cV_Devices.Id_CV_Devices)
            {
                return BadRequest();
            }

            _context.Entry(cV_Devices).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CV_DevicesExists(id))
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

        // POST: api/CV_Devices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CV_Devices>> PostCV_Devices(CV_Devices cV_Devices)
        {
            _context.CV_Devices.Add(cV_Devices);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCV_Devices", new { id = cV_Devices.Id_CV_Devices }, cV_Devices);
        }

        // DELETE: api/CV_Devices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CV_Devices>> DeleteCV_Devices(int id)
        {
            var cV_Devices = await _context.CV_Devices.FindAsync(id);
            if (cV_Devices == null)
            {
                return NotFound();
            }

            _context.CV_Devices.Remove(cV_Devices);
            await _context.SaveChangesAsync();

            return cV_Devices;
        }

        private bool CV_DevicesExists(int id)
        {
            return _context.CV_Devices.Any(e => e.Id_CV_Devices == id);
        }
    }
}
