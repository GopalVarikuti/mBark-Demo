using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Demo.Service.Contracts;
using Demo.Service.Helpers;
using Demo.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult AuthLogin([FromBody] LoginRequest loginrequest)
        {
            var username = loginrequest.Username;

            var password = loginrequest.Password;
            IActionResult response = Unauthorized();
            var Parent = new Dictionary<string, object>();

            var Errors = new List<object>();
            var Warnings = new List<object>();

            using (mBarkDemoAppContext db = new mBarkDemoAppContext())
            {
                try
                {
                    var entity = db.Userslogin.Where(e => (e.Username == username && e.Password == password)).FirstOrDefault();

                    var user = AuthenticateUser(loginrequest);

                    if (user != null)
                    {
                        var tokenString = GenerateJSONWebToken(user);

                        Parent.Add("access_token", tokenString);
                        Parent.Add("token_type", "bearer");
                        Parent.Add("expires_in", TimeSpan.FromDays(1));
                        Parent.Add("userName", loginrequest.Username);
                        Parent.Add("roles", loginrequest.Username);
                        Parent.Add("initialPasswordChanged", "true");
                        Parent.Add(".issued", DateTime.Now);
                        Parent.Add(".expires", DateTime.Now.AddDays(1));
                    }
                    else
                    {
                        Parent.Add("Errors", Errors.ToList());
                        Parent.Add("Warning", Warnings.ToList());
                        Parent.Add("HttpstatusCode", HttpStatusCode.BadRequest);
                    }
                }
                catch (Exception)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "something went wrong");
                }

            }
            return this.Request.CreateResponse(HttpStatusCode.OK, Parent);
        }

        private string GenerateJSONWebToken(LoginRequest loginrequest)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private LoginRequest AuthenticateUser(LoginRequest loginrequest)
        {
            LoginRequest user = null;
            //Validate the User Credentials  
            if (loginrequest.Username == loginrequest.Username)
            {
                user = new LoginRequest { Username = loginrequest.Username, Password = loginrequest.Password };
            }
            return user;
        }
    }
}