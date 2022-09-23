using CustomerLogin.Models;
using CustomerLogin.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginDBContext db;
        public LoginController(LoginDBContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var Islogin=db.TblLogins.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password);

            return Ok(new {IsLogin= Islogin, Message= Islogin?"Successfully login":"Either username or password is incorrect" });
        }
    }
}
