using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.09. 字符串轮转
/// https://leetcode-cn.com/problems/string-rotation-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 字符串轮转
    {
        public bool IsFlipedString(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1)) return string.IsNullOrEmpty(s2);
            if (string.IsNullOrEmpty(s2)) return string.IsNullOrEmpty(s1);
            if (s1.Length != s2.Length) return false;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s1)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic.Add(c, 1);
            }
            foreach (char c in s2)
            {
                if (!dic.ContainsKey(c))
                    return false;
                dic[c]--;
            }
            return dic.Values.All(i => i == 0);
        }
    }
}
