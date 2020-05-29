using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 392. 判断子序列
/// https://leetcode-cn.com/problems/is-subsequence/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00392_判断子序列
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(t)) return string.IsNullOrEmpty(s);
            if (string.IsNullOrEmpty(s)) return !string.IsNullOrEmpty(t);
            int len1 = s.Length, len2 = t.Length, index = 0;
            for (int i = 0; i < len2; i++)
            {
                if (index >= len1) break;
                if (t[i] == s[index])
                    index++;
            }
            return index == s.Length;
        }
    }
}
