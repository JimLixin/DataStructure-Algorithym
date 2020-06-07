using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 32. 最长有效括号
/// https://leetcode-cn.com/problems/longest-valid-parentheses/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00032_最长有效括号
    {
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int[] dp = new int[s.Length];
            int max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (s[i - 1] == '(')
                        dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                    else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1] == '(')
                        dp[i] = dp[i - 1] + ((i - dp[i - 1]) >= 2 ? dp[i - dp[i - 1] - 2] : 0) + 2;
                    if (dp[i] > max) max = dp[i];
                }
            }
            return max;
        }
    }
}
