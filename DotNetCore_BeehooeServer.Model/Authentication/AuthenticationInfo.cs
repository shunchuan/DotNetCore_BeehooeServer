using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore_BeehooeServer.Model.Authentication
{
    public class AuthenticationInfo
    {
        public string AccessKey { get; set; }

        public string AccessKeySecret { get; set; }

        public AuthenticationInfo(string accessKey,string accessKeySecret)
        {
            AccessKey = accessKey;
            AccessKeySecret = accessKeySecret;
        }

        public AuthenticationInfo()
        {
        }
    }
}
