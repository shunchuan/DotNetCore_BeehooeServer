using System;
using System.Collections.Generic;
using System.Text;
using DotNetCore_BeehooeServer.Domain;
using DotNetCore_BeehooeServer.Domain.Entity;
using DotNetCore_BeehooeServer.Domain.IRepository;
using MSSql = DotNetCore_BeehooeServer.Domain.MSSql_Repository;

namespace DotNetCore_BeehooeServer.Business
{
    public class UserBusiness
    {
        public IEnumerable<string> GetUserName()
        {
            var userInfo = DataAccess<IUserInfoRepository>.CreateObject("UserInfo");
            return userInfo.GetUserName();
        }

        public IEnumerable<UserInfo> GetUserInfos()
        {
            var userInfo = DataAccess<IUserInfoRepository>.CreateObject("UserInfo");
            return userInfo.GetAll<UserInfo>();
        }
    }
}
