using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersTypesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public UsersTypesController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersType>>> GetUsersType()
        {
            return await _context.UsersType.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsersType>> GetUsersType(int id)
        {
            var usersType = await _context.UsersType.FindAsync(id);

            if (usersType == null)
            {
                return NotFound();
            }

            return usersType;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsersType(int id, UsersType usersType)
        {
            if (id != usersType.Id_UsersType)
            {
                return BadRequest();
            }

            _context.Entry(usersType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersTypeExists(id))
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
        public async Task<ActionResult<UsersType>> PostUsersType(UsersType usersType)
        {
            _context.UsersType.Add(usersType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsersType", new { id = usersType.Id_UsersType }, usersType);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsersType>> DeleteUsersType(int id)
        {
            var usersType = await _context.UsersType.FindAsync(id);
            if (usersType == null)
            {
                return NotFound();
            }

            _context.UsersType.Remove(usersType);
            await _context.SaveChangesAsync();

            return usersType;
        }

        private bool UsersTypeExists(int id)
        {
            return _context.UsersType.Any(e => e.Id_UsersType == id);
        }
    }
}
