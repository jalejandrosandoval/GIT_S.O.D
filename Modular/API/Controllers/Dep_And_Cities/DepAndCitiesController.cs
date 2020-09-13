using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models.Col;

namespace API.Controllers.Dep_And_Cities
{
    /// <summary>
    /// Controller for the obtention the diferent data of the Colombia Cities and Departments.
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]

    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)
    public class DepAndCitiesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public DepAndCitiesController(AppDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET: API/GetDeparments.
        /// - Getting the data about the departments of Colombia.
        /// </summary>
        /// <returns>Object in .JSON the deparments</returns>
        
        [HttpGet]
        [Route("GetDeparments")]
        public async Task<ActionResult<IEnumerable<DepartmentsCol>>> GetDepartmentsCol()
        {
            return await _context.DepartmentsCols.ToListAsync();
        }

        /// <summary>
        /// GET: API/GetDeparments.
        /// - Getting the data about the departments of Colombia from param id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET / GetDeparments
        ///     {
        ///        "id": 1,
        ///     }
        ///     
        /// </remarks>
        /// <returns>Object in .JSON the deparments</returns>
        
        [HttpGet("GetDeparments/{id}")]
        public async Task<ActionResult<DepartmentsCol>> GetDepartmentsCol(int id)
        {
            var departmentsCol = await _context.DepartmentsCols.FindAsync(id);

            if (departmentsCol == null)
            {
                return NotFound();
            }

            return departmentsCol;
        }

        /// <summary>
        /// GET: API/GetCities.
        /// - Getting the data about the Cities of Colombia.
        /// </summary>
        /// <returns>Object in JSON the Cities</returns>

        [HttpGet]
        [Route("GetCities")]
        public async Task<ActionResult<IEnumerable<CitiesCol>>> GetCitiesCol()
        {
            return await _context.CitiesCols.ToListAsync();
        }

        /// <summary>
        /// GET: API/GetCities.
        /// - Getting the data about the Cities of Colombia from param id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET / GetCities
        ///     {
        ///        "id": 1,
        ///     }
        ///     
        /// </remarks>
        /// <returns>Object in .JSON the cities data by departments</returns>

        [HttpGet("GetCities/{id}")]
        public async Task<ActionResult<CitiesCol>> GetCitiessCol(int id)
        {
            var citiesCol = await _context.CitiesCols.FindAsync(id);

            if (citiesCol == null)
            {
                return NotFound();
            }

            return citiesCol;
        }

        /// <summary>
        /// GET: API/GetCitiesByDptos.
        /// - Getting the data about the cities by departments of Colombia with a param id .
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET / GetCitiesByDptos
        ///     {
        ///        "id": 1,
        ///     }
        ///     
        /// </remarks>
        /// <returns>Object in .JSON the deparments</returns>

        [HttpGet("GetCitiesByDptos/{id}")]
        public async Task<ActionResult<IEnumerable<CitiesCol>>> GetDepartmentsByCitiesCol(int id)
        {

            var result = await _context.CitiesCols
                              .Where(d => d.DepartmentsCol.Id_Departments == id)
                              .ToListAsync();

            if (result.Count == 0)
            {
                return NotFound();
            }

            return result;

        }
        
    }
}