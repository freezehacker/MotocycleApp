using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotocycleApp
{
    public class StringUtils
    {
        public static string splitId(string id)
        {
            // 把身份证每个部分分隔开来
            // 示例：441224 19900729 0815
            string ret = "";
            if (id.Length > 0)
            {
                ret += id.Substring(0, Math.Min(6, id.Length));
            }
            if (id.Length > 6)
            {
                ret += " " + id.Substring(6, Math.Min(8, id.Length - 6));
            }
            if (id.Length > 14)
            {
                ret += " " + id.Substring(14);
            }
            return ret;
        }
    }
}
