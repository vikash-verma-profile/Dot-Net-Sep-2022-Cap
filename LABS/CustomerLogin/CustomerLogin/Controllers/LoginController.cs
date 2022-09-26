using CustomerLogin.Models;
using CustomerLogin.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginDBContext db;
        private IConfiguration config;
        public LoginController(LoginDBContext _db,IConfiguration _config)
        {
            db = _db;
            config = _config;
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var Islogin=db.TblLogins.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password);
            var token=GenerateToken(loginViewModel);
            return Ok(new {IsLogin= Islogin,Token= token, Message = Islogin?"Successfully login":"Either username or password is incorrect" });
        }

        private string GenerateToken(LoginViewModel loginViewModel)
        {
            var key = config["jwt:Key"];
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var token = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, loginViewModel.UserName)
                }),
                Expires = DateTime.Now.AddMinutes(120),
                SigningCredentials = credentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenjson = tokenHandler.CreateToken(token);
            return tokenHandler.WriteToken(tokenjson);
        
        }
    }
}
