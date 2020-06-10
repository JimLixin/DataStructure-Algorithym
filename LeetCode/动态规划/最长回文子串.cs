using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 5. 最长回文子串
/// https://leetcode-cn.com/problems/longest-palindromic-substring/
/// </summary>
namespace Algorithym.LeetCode.动态规划
{
    public class 最长回文子串
    {
        public string Answer(string s)
        {
            if (s == null || String.IsNullOrEmpty(s))
                return "";

            string ans = "";
            int max = 0;
            int len = s.Length;
            bool[,] dp = new bool[len, len];

            for (int i = len - 1; i >= 0; i--)
            {
                for (int j = i; j < len; j++)
                {
                    if (j - i <= 1)
                        dp[i, j] = (s[i] == s[j]);
                    else
                        dp[i, j] = (s[i] == s[j]) && dp[i + 1, j - 1];

                    if (dp[i, j] && j - i + 1 > max)
                    {
                        max = j - i + 1;
                        ans = s.Substring(i, j - i + 1);
                    }

                }
            }
            return ans;
        }
    }
}
