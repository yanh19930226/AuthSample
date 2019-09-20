using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JwtAuthSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using System.Text;
using System.IdentityModel.Tokens.Jwt;


namespace JwtAuthSample.Controllers
{
    [Route("api/[controller]")]
    public class AuthorizeController : Controller
    {
        public JwtSettings _jwtSettings { get; set; }
        public AuthorizeController(IOptions<JwtSettings> _jwtSettingsAcesser)
        {
            _jwtSettings = _jwtSettingsAcesser.Value;
        }
        [HttpPost]
        public IActionResult Token(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!(model.UserName == "yanh" && model.Pwd == "123"))
                {
                    return BadRequest();
                }
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,"yanh"),
                    new Claim(ClaimTypes.Role,"admin"),
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
                var cred = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_jwtSettings.Issuer, _jwtSettings.Audience, claims, DateTime.Now, DateTime.Now.AddMinutes(30),cred);
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            return BadRequest();
        }
    }
}