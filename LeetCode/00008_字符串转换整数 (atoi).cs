using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 8. 字符串转换整数 (atoi)
    /// https://leetcode-cn.com/problems/string-to-integer-atoi/
    /// </summary>
    public static class StringtoInteger
    {
        public static int Answer(string str)
        {
            int result = 0;
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && output.Length == 0)
                    continue;
                if ((str[i] == '-' || str[i] == '+') && output.Length == 0 || (str[i] >= '0' && str[i] <= '9'))
                {
                    output.Append(str[i]);
                }
                else
                {
                    break;
                }
            }
            var strOutput = output.ToString();
            if (strOutput.Length == 1 && (strOutput[0] == '-' || strOutput[0] == '+'))
            {
                strOutput = strOutput.Remove(0, 1);
            }
            if (strOutput.Length > 0)
            {
                if (int.TryParse(strOutput, out result))
                {
                    return result;
                }
                else
                {
                    return strOutput[0] == '-' ? int.MinValue : int.MaxValue;
                }
            }
            else
                return 0;
        }
    }
}
