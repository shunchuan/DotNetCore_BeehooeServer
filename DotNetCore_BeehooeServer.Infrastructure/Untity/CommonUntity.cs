using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore_BeehooeServer.Infrastructure.Untity
{
    public class CommonUntity
    {
        #region 时间戳互转

        /// <summary>
        /// Self:当前时间(Unix)
        /// </summary>
        /// <returns>返回当前Unix时间</returns>
        public static long GetUnix(DateTime? dt=null)
        {
            dt = dt ?? DateTime.Now;
            var tick = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0)).Ticks;
            return (((DateTime)dt).Ticks - tick) / 100000;
        }

        public static DateTime GetUnixDatetime(long timestamp)
        {
            var tick = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0)).Ticks;
            return new DateTime(timestamp*100000 + tick);
        }

        #endregion
    }
}
