using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Models;

namespace ApiRest_Estudiante.Controllers
{
    [AllowAnonymous]
    public class AccountController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Login(Login loginDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bool isCredencial = (loginDTO.password == "1234");

            if (isCredencial)
            {
                var token = TokenGenerator.GenerateTokenJwt(loginDTO.username);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
