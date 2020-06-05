using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 10. 正则表达式匹配
/// https://leetcode-cn.com/problems/regular-expression-matching/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 递归
    /// </summary>
    public class _00010_正则表达式匹配
    {
        public bool IsMatch(string s, string p)
        {
            return isMatch(s, 0, p, 0);
        }

        public bool isMatch(string s, int sStart, string p, int pStart)
        {
            if (pStart >= p.Length) return sStart >= s.Length;
            bool startMatch = sStart < s.Length && (p[pStart] == '.' || p[pStart] == s[sStart]);
            if (p.Length - pStart >= 2 && p[pStart + 1] == '*')
                return startMatch && isMatch(s, sStart + 1, p, pStart) || isMatch(s, sStart, p, pStart + 2);
            else
                return startMatch && isMatch(s, sStart + 1, p, pStart + 1);
        }
    }

    /// <summary>
    /// 动态规划
    /// </summary>
    public class _00010_正则表达式匹配V2
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[s.Length, p.Length] = true;
            for (int i = s.Length; i >= 0; i--)
            {
                for (int j = p.Length - 1; j >= 0; j--)
                {
                    bool firstMatch = i < s.Length && (p[j] == '.' || p[j] == s[i]);
                    if (j < p.Length - 1 && p[j + 1] == '*')
                        dp[i, j] = firstMatch && dp[i + 1, j] || dp[i, j + 2];
                    else
                        dp[i, j] = firstMatch && dp[i + 1, j + 1];
                }
            }
            return dp[0, 0];
        }
    }
}
