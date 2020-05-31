using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1370. 上升下降字符串
/// https://leetcode-cn.com/problems/increasing-decreasing-string/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01370_上升下降字符串
    {
        public string SortString(string s)
        {
            int len = s.Length, pos = 0;
            char[] result = new char[len];
            int[] data = new int[123];
            for (int n = 0; n < len; n++) data[s[n]]++;
            while (pos < len)
            {
                for (int i = 97; i < 123; i++)
                {
                    if (pos == len) break;
                    if (data[i] == 0) continue;
                    result[pos++] = (char)i;
                    data[i]--;
                }
                for (int i = 122; i >= 97; i--)
                {
                    if (pos == len) break;
                    if (data[i] == 0) continue;
                    result[pos++] = (char)i;
                    data[i]--;
                }
            }

            return new String(result);
        }
    }
}
