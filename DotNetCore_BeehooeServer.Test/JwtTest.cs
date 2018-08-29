using System;
using System.Collections.Generic;
using System.Text;
using DotNetCore_BeehooeServer.Infrastructure.Jwt;
using DotNetCore_BeehooeServer.Model.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCore_BeehooeServer.Test
{
    [TestClass]
    public class JwtTest
    {
        [TestMethod]
        public void GenerateToken()
        {
            var token= new JwtManager().GenerateToken(new JwtClaimModel() {RoleId = "TheRoleID", RoleName = "TheRoleName"});
        }
    }
}
