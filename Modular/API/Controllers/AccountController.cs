using API.Data;
using API.Models;
using Bussiness_Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {        
        private readonly IConfiguration _configuration;
        private readonly AppDBContext _context;

        public AccountController(AppDBContext Context, IConfiguration configuration)
        {
            _context = Context;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {

                //var result = await _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.UserPassword, isPersistent: false, lockoutOnFailure: false);

                var result = await _context.Users
                                    .Where(u => u.Username == loginModel.Username && u.UserPassword == loginModel.UserPassword)
                                    .ToListAsync();

                if (result.Count != 0)
                {
                    //ModelState.AddModelError(string.Empty, "Res:" + " " + result.Count.ToString());
                    //return BadRequest(ModelState);
                    return BuildToken(loginModel);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Intento de inicio de sesión no válido...");
                    return BadRequest(ModelState);
                    //return BuildToken(loginModel);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        //*/
        /*
        private readonly AppDBContext Context;

        public AccountController(AppDBContext _Context, IConfiguration configuration)
        {
            Context = _Context;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (ModelState.IsValid) {


                var _user = await Context.Users
                                    .Where(u => u.Username == loginModel.Username && u.UserPassword == loginModel.UserPassword)
                                    .ToListAsync();

                if (_user == null) //|| resultUPass == null)
                {
                    return NotFound(ModelState);
                }
                else 
                {
                    return BuildToken(loginModel);
                }

            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        */

        private IActionResult BuildToken(LoginModel loginModel)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, loginModel.Username), // Information by JWT
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // Identification Token
            };

            //JWT

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Key"])); //Key Secret
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256); //Enconding With Algoritm HmaScha256

            var expiration = DateTime.UtcNow.AddHours(1); // ExpirationToken

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: "Petroco.com.co",
               audience: "Petroco.com.co",
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return Ok(new
            {
                _token = new JwtSecurityTokenHandler().WriteToken(token),
                _expiration = expiration
            });

        }
        
    }
}