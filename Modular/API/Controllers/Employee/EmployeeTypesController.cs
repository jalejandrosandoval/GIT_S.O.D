using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models.Employee;

namespace API.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTypesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public EmployeeTypesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeType>>> GetEmployeeTypes()
        {
            return await _context.EmployeeTypes.ToListAsync();
        }

        // GET: api/EmployeeTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeType>> GetEmployeeType(int id)
        {
            var employeeType = await _context.EmployeeTypes.FindAsync(id);

            if (employeeType == null)
            {
                return NotFound();
            }

            return employeeType;
        }

        // PUT: api/EmployeeTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeType(int id, EmployeeType employeeType)
        {
            if (id != employeeType.Id_EmployeeType)
            {
                return BadRequest();
            }

            _context.Entry(employeeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeTypeExists(id))
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

        // POST: api/EmployeeTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmployeeType>> PostEmployeeType(EmployeeType employeeType)
        {
            _context.EmployeeTypes.Add(employeeType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeType", new { id = employeeType.Id_EmployeeType }, employeeType);
        }

        // DELETE: api/EmployeeTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeType>> DeleteEmployeeType(int id)
        {
            var employeeType = await _context.EmployeeTypes.FindAsync(id);
            if (employeeType == null)
            {
                return NotFound();
            }

            _context.EmployeeTypes.Remove(employeeType);
            await _context.SaveChangesAsync();

            return employeeType;
        }

        private bool EmployeeTypeExists(int id)
        {
            return _context.EmployeeTypes.Any(e => e.Id_EmployeeType == id);
        }
    }
}
