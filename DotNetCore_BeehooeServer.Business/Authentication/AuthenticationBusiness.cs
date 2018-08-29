using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_BeehooeServer.Infrastructure;
using DotNetCore_BeehooeServer.Infrastructure.Configurate;
using DotNetCore_BeehooeServer.Infrastructure.Jwt;
using DotNetCore_BeehooeServer.Infrastructure.Untity;
using DotNetCore_BeehooeServer.Model;
using DotNetCore_BeehooeServer.Model.Authentication;
using DotNetCore_BeehooeServer.Model.Request;

namespace DotNetCore_BeehooeServer.Business.Authentication
{
    public class AuthenticationBusiness: IAuthenticationBusiness
    {
        public async Task<ResponseBase> Authentication(AuthenticationRequest input)
        {
            var authenticationModel = ConfigManager.GetValue<AuthenticationConfig>(MagicValue.AUTHENTICATION_CONFIG);
            if (CommonUntity.GetUnixDatetime(input.Timestamp) <=
                DateTime.Now.AddSeconds(0 - authenticationModel.ExpireSeconds))
            {
                return new ResponseBase("204", "Timestamp is not avilid");
            }

            var authentications = new List<AuthenticationInfo>
            {
                new AuthenticationInfo("key", "keySecret")
            };

            var authentication = authentications.FirstOrDefault(c => c.AccessKey == input.AccessKeyId);
            var keySecret = authentication?.AccessKeySecret;
            if (string.IsNullOrEmpty(keySecret))
            { 
                return new ResponseBase("501");
            }

            var localSignature= (input.AccessKeyId + input.Timestamp.ToString()).HmacSha256(keySecret);
            if (!String.Equals(localSignature, input.Signature, StringComparison.CurrentCultureIgnoreCase))
            {
                return new ResponseBase("501");
            }

            return new ResponseBase("1","", new JwtManager().GenerateToken(authentication));
        }
    }
}
