using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 647. 回文子串
/// https://leetcode-cn.com/problems/palindromic-substrings/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00647_回文子串
    {
        public int CountSubstrings(string s)
        {
            int count = 0;
            bool[,] dp = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (i == j)
                        dp[j, i] = true;
                    if (i - j == 1)
                        dp[j, i] = s[i] == s[j];
                    else if (i - j > 1)
                        dp[j, i] = dp[j + 1, i - 1] && s[i] == s[j];
                    if (dp[j, i]) count++;
                }
            }
            return count;
        }
    }
}
