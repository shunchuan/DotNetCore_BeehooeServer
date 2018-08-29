using System;
using System.Collections.Generic;
using System.Text;
using DotNetCore_BeehooeServer.Domain.RepositoryBase;
using DotNetCore_BeehooeServer.Model.Entity;

namespace DotNetCore_BeehooeServer.Domain.IRepository
{
    public interface IUserInfoRepository: IDapperRepositoryBase
    {
        IEnumerable<string> GetUserName();
    }
}
