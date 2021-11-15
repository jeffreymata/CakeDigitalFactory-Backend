using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDigitalFactory.Services.Features.Login
{
    [Route("api/[controller]")]
    [ApiController]

   
    public class LoginController : ControllerBase
    {
        private readonly LoginServices _loginServices;
        public LoginController(LoginServices loginServices)
        {
            _loginServices = loginServices; 
        }

        [HttpGet]
        [Route("login-validation/{username}/{passWord}")]

        public ActionResult loginValidation(string username, string passWord)
        {
            return Ok(_loginServices.GetLoginValidation(username,  passWord));
        }
    }
}
