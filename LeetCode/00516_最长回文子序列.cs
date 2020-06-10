using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 516. 最长回文子序列
/// https://leetcode-cn.com/problems/longest-palindromic-subsequence/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00516_最长回文子序列
    {
        public int LongestPalindromeSubseq(string s)
        {
            int len = s.Length;
            int[,] dp = new int[len, len];
            for (int i = len - 1; i >= 0; i--)
            {
                dp[i, i] = 1;
                for (int j = i + 1; j < len; j++)
                {
                    if (s[i] == s[j])
                        dp[i, j] = dp[i + 1, j - 1] + 2;
                    else
                        dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);
                }
            }
            return dp[0, len - 1];
        }
    }
}
