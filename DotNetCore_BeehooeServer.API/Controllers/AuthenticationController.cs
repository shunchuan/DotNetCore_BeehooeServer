using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_BeehooeServer.API.Extensions;
using DotNetCore_BeehooeServer.Business.Authentication;
using DotNetCore_BeehooeServer.Model;
using DotNetCore_BeehooeServer.Business.Authentication;
using DotNetCore_BeehooeServer.Model.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_BeehooeServer.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        [Route("api/Authentication")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Authentication([FromBody]AuthenticationRequest input)
        {
            if (!ModelState.IsValid)
            {
                return new ResponseBase("204", "", ModelState).ToActionResult();
            }

            IAuthenticationBusiness business=new AuthenticationBusiness();

            return business.Authentication(input).ToActionResult();
        }
    }
}