using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DotNetCore_BeehooeServer.Model;
using DotNetCore_BeehooeServer.Model.Request;

namespace DotNetCore_BeehooeServer.Business.Authentication
{
    public interface IAuthenticationBusiness
    {
        Task<ResponseBase> Authentication(AuthenticationRequest input);
    }
}
