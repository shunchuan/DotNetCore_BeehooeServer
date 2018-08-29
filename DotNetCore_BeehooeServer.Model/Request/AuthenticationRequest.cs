using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore_BeehooeServer.Model.Request
{
    public class AuthenticationRequest
    {
        [Required]
        public string AccessKeyId { get; set; }

        [Required]
        public string Signature { get; set; }

        [Required]
        public long Timestamp { get; set; }
    }
}
