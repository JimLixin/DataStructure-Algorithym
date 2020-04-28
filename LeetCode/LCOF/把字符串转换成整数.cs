using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题67. 把字符串转换成整数
    /// https://leetcode-cn.com/problems/ba-zi-fu-chuan-zhuan-huan-cheng-zheng-shu-lcof/
    /// </summary>
    public class 把字符串转换成整数
    {
        public int StrToInt(string str)
        {
            str = str.Trim();
            if (str == "") return 0;
            bool negative = false;
            if (str[0] == '-' || str[0] == '+')
            {
                negative = (str[0] == '-');
                str = str.Substring(1);
            }

            int i = 0;
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                i++;
            }
            int result = 0;
            if (i == 0) return result;

            if (!int.TryParse(str.Substring(0, i), out result))
                result = negative ? int.MinValue : int.MaxValue;
            else
                result = negative ? -result : result;
            return result;
        }
    }
}
