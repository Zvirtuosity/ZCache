using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCacheProj
{
    public static class MathUtils
    {
        private static string _runtimePath;
        /// <summary>
        /// 获得运行时路径.
        /// </summary>
        public static string RuntimePath
        {
            get
            {
                return _runtimePath ?? (_runtimePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToHexMd5Hash(string str)
        {
            return CryptoHelper.ToMd5Hash(str);
        }
    }
}
