using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Bussiness_Logic.Models.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Config_Init
{
    /// <summary>
    /// Controller for the obtention the diferent data for make the configuration in the website.
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]

    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)
    public class Config_InitiController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Config_InitiController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Configuration_Initial>>> GetConfig()
        {
            return await _context.Configuration_Initial.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Configuration_Initial>> GetConfig(int id)
        {
            var config = await _context.Configuration_Initial.FindAsync(id);

            if (config == null)
            {
                return NotFound();
            }

            return config;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Configuration_Initial config)
        {
            if (id != config.ID_ConfigInit)
            {
                return BadRequest();
            }

            _context.Entry(config).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfigExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Configuration_Initial>> PostUsers(Configuration_Initial config)
        {
            _context.Configuration_Initial.Add(config);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = config.ID_ConfigInit }, config);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Configuration_Initial>> DeleteUsers(int id)
        {
            var config = await _context.Configuration_Initial.FindAsync(id);

            if (config == null)
            {
                return NotFound();
            }

            _context.Configuration_Initial.Remove(config);
            await _context.SaveChangesAsync();

            return config;
        }

        private bool ConfigExists(int id)
        {
            return _context.Users.Any(e => e.Id_Users == id);
        }

    }
}