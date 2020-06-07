using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 402. 移掉K位数字
/// https://leetcode-cn.com/problems/remove-k-digits/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _00402_移掉K位数字
    {
        public string RemoveKdigits(string num, int k)
        {
            if (string.IsNullOrEmpty(num)) return "";
            if (num.Length == k) return "0";
            if (k == 0) return num;

            int len = num.Length;
            List<char> data = new List<char>(num.ToCharArray());
            while (k > 0 && len > 0)
            {
                if (data[0] == '0')
                {
                    data.RemoveAt(0);
                    len--;
                }
                int pos = len - 1;
                for (int i = 1; i < len; i++)
                {
                    if (data[i] < data[i - 1])
                    {
                        pos = i - 1;
                        break;
                    }
                }
                data.RemoveAt(pos);
                len--;
                k--;
            }
            string result = new String(data.ToArray()).TrimStart('0');
            return result == "" ? "0" : result;
        }
    }
}
