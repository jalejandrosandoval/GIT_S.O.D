using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        
        

        public AccountController(SignInManager<ApplicationUser> signInManager,
             IConfiguration configuration)
        {

            _signInManager = signInManager;
            _configuration = configuration;

        }
        /*
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginMo loginModel)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.UserPassword, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
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

        }*/


    }
}