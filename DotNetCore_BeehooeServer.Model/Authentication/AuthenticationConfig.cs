using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore_BeehooeServer.Model.Authentication
{
    public class AuthenticationConfig
    {
        public double ExpireSeconds { get; set; }

        public string SecretSalt { get; set; }

        public AuthenticationConfig()
        {

        }
    }
}
