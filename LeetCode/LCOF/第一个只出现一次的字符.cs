using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题50. 第一个只出现一次的字符
    /// https://leetcode-cn.com/problems/di-yi-ge-zhi-chu-xian-yi-ci-de-zi-fu-lcof/
    /// </summary>
    public class 第一个只出现一次的字符
    {
        public char FirstUniqChar(string s)
        {
            Dictionary<char, int> data = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!data.ContainsKey(s[i]))
                    data.Add(s[i], 1);
                else
                    data[s[i]]++;
            }
            foreach (var k in data.Keys)
            {
                if (data[k] == 1) return k;
            }
            return ' ';
        }
    }
}
