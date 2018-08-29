using System;
using System.Collections.Generic;
using System.Text;
using DotNetCore_BeehooeServer.Domain;
using DotNetCore_BeehooeServer.Domain.IRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCore_BeehooeServer.Test
{
    [TestClass]
    public class DomainTest
    {
        [TestMethod]
        public void GetDataAccess()
        {
            Assert.IsInstanceOfType(DataAccess<IUserInfoRepository>.CreateObject("UserInfo"), typeof(IUserInfoRepository));
        }
    }
}
