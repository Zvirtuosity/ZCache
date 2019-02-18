using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZCacheProj.Redis
{
    /// <summary>
    /// 
    /// </summary>
    public enum RedisStorageVersion
    {
        /// <summary>
        /// first version
        /// </summary>
        Default = 0,
        /// <summary>
        /// Entity use hash storage version.
        /// </summary>
        Hash = 5,
        /// <summary>
        /// Entity use hash storage and mutil key use map find version.
        /// </summary>
        HashMutilKeyMap = 7
    }

    public static class RedisConnectionPool
    {
        
        private static void InitRedis()
        {
            RedisInfo info = null;

            info = "".ParseJson<RedisInfo>();

            string host = Dns.GetHostName();
            string serverPath = MathUtils.RuntimePath;
            string hashCode = MathUtils.ToHexMd5Hash(host + serverPath);

            info.HashCode = hashCode;
            info.ServerPath = serverPath;
            //info.ServerHost = host;
            info.StarTime = DateTime.Now;


        }
    }
}
