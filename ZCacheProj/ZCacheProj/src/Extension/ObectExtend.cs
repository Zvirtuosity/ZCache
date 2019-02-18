using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCacheProj
{
    public static class ObectExtend
    {
        /// <summary>
        /// 解析Json成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T ParseJson<T>(this string jsonStr)
        {
            return JsonUtils.DeserializeCustom<T>(jsonStr);
        }
    }
}
