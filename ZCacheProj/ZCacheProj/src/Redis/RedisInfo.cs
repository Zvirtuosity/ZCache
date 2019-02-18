using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCacheProj.Redis
{
    public class RedisInfo
    {
        public RedisInfo()
        {
            ClientVersion = RedisStorageVersion.Hash;
            //SlaveSet = new Dictionary<string, RedisInfo>();
        }
        /// <summary>
        /// Server info hash
        /// </summary>
        public string HashCode { get; set; }

        /// <summary>
        /// Redis client version
        /// </summary>
        public RedisStorageVersion ClientVersion { get; set; }

        /// <summary>
        /// Server Path;
        /// </summary>
        public string ServerHost { get; set; }

        /// <summary>
        /// Application Path
        /// </summary>
        public string ServerPath { get; set; }
        /// <summary>
        ///  Json Or Protobuf , Default is Protobuf;
        /// </summary>
        public string SerializerType { get; set; }

        /// <summary>
        /// Server Start Time
        /// </summary>
        public DateTime StarTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public Dictionary<string, RedisInfo> SlaveSet { get; set; }
    }
}
