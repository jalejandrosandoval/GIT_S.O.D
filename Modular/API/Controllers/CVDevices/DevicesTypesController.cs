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
    public class DevicesTypesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public DevicesTypesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/DevicesTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DevicesTypes>>> GetDevicesTypes()
        {
            return await _context.DevicesTypes.ToListAsync();
        }

        // GET: api/DevicesTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DevicesTypes>> GetDevicesTypes(int id)
        {
            var devicesTypes = await _context.DevicesTypes.FindAsync(id);

            if (devicesTypes == null)
            {
                return NotFound();
            }

            return devicesTypes;
        }

        // PUT: api/DevicesTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDevicesTypes(int id, DevicesTypes devicesTypes)
        {
            if (id != devicesTypes.Id_DevicesTypes)
            {
                return BadRequest();
            }

            _context.Entry(devicesTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DevicesTypesExists(id))
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

        // POST: api/DevicesTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DevicesTypes>> PostDevicesTypes(DevicesTypes devicesTypes)
        {
            _context.DevicesTypes.Add(devicesTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDevicesTypes", new { id = devicesTypes.Id_DevicesTypes }, devicesTypes);
        }

        // DELETE: api/DevicesTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DevicesTypes>> DeleteDevicesTypes(int id)
        {
            var devicesTypes = await _context.DevicesTypes.FindAsync(id);
            if (devicesTypes == null)
            {
                return NotFound();
            }

            _context.DevicesTypes.Remove(devicesTypes);
            await _context.SaveChangesAsync();

            return devicesTypes;
        }

        private bool DevicesTypesExists(int id)
        {
            return _context.DevicesTypes.Any(e => e.Id_DevicesTypes == id);
        }
    }
}
