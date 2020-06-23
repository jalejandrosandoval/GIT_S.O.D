using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsersController : ControllerBase
    {
        private readonly AppDBContext _ContextUsers;

        public UsersController(AppDBContext context)
        {
            _ContextUsers = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            return await _ContextUsers
                        .Users
                        .Include(u => u.UserType)
                        .Where(u => u.UserType.Id_UsersType == u.Id_UsersType)
                        .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int id)
        {
            var users = await _ContextUsers.Users.FindAsync(id);

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users users)
        {
            if (id != users.Id_Users)
            {
                return BadRequest();
            }

            _ContextUsers.Entry(users).State = EntityState.Modified;

            try
            {
                await _ContextUsers.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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
        public async Task<ActionResult<Users>> PostUsers(Users users)
        {
            _ContextUsers.Users.Add(users);
            await _ContextUsers.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = users.Id_Users }, users);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> DeleteUsers(int id)
        {
            var users = await _ContextUsers.Users.FindAsync(id);

            if (users == null)
            {
                return NotFound();
            }

            _ContextUsers.Users.Remove(users);
            await _ContextUsers.SaveChangesAsync();

            return users;
        }

        private bool UsersExists(int id)
        {
            return _ContextUsers.Users.Any(e => e.Id_Users == id);
        }
    }
}
