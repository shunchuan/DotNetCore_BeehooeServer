using System;
using System.Collections.Generic;
using System.Text;
using DotNetCore_BeehooeServer.Domain.IRepository;
using DotNetCore_BeehooeServer.Domain.RepositoryBase;
using DotNetCore_BeehooeServer.Model.Entity;

namespace DotNetCore_BeehooeServer.Domain.MSSql_Repository
{
    public class UserInfoRepository: DapperRepositoryBase//, IUserInfoRepository
    {
        public IEnumerable<string> GetUserName()
        {
            string sql = "select  name from userInfo";
            return Query<string>(sql);
        }
    }
}
