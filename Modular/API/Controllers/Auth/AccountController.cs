using API.Data;
using Bussiness_Logic.Models.Auth;
using Bussiness_Logic.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers.Auth
{
    /// <summary>
    /// Contoller for make the Authentication in the APP by utilization of JWT
    /// </summary>
    
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

        /// <summary>
        /// EndPoint -> GetUser
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns>If the credentials are correct return the user</returns>
        
        [HttpPost]
        [Route("GetUser")]
        public async Task<IEnumerable<Users>> GetUser([FromBody] LoginModel loginModel)
        {
            return await _context.Users
                                .Where(u => u.Username == loginModel.Username && u.UserPassword == loginModel.UserPassword)
                                .ToListAsync();   
        }

        /// <summary>
        /// EndPoint -> Login. This endopoint valid the credentials and calls the other method by make the generation of Authentiaction Token.
        /// </summary>
        /// <param name="loginModel">Model Of Login Model</param>
        /// <returns>A good o but request depends of the credentials and the requests params </returns>

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
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
                    ModelState.AddModelError(string.Empty, "¡Intento de inicio de sesión no válido! Verifique su Usuario y Contraseña...");
                    return BadRequest(ModelState);
                    //return BuildToken(loginModel);
                }

            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        /// <summary>
        /// Method by the creatin on token through the JWT and the claims
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        
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