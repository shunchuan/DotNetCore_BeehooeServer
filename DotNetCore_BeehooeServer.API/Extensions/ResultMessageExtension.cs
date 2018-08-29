using System.Threading.Tasks;
using DotNetCore_BeehooeServer.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_BeehooeServer.API.Extensions
{
    public static class ResultMessageExtension
    {
        /// <summary>
        /// ResponseBase根据状态自动转换为IActionResult
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static IActionResult ToActionResult(this ResponseBase result)
        {
            switch (result.Status)
            {
                case "1":
                {
                    return new OkObjectResult(result);
                }
                case "0":
                {
                    return new BadRequestObjectResult(result);
                }
                default:
                    return new OkObjectResult(result);
            }
        }

        public static IActionResult ToActionResult(this Task<ResponseBase> resulTask)
        {
            var result = resulTask.Result;
            if (result != null)
            {
                switch (result.Status)
                {
                    case "1":
                    {
                        return new OkObjectResult(result);
                    }
                    case "0":
                    {
                        return new BadRequestObjectResult(result);
                    }
                    default:
                        return new OkObjectResult(result);
                }
            }
            return null;
        }
    }
}
