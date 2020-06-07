using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Dynamic_Progamming
{
    /// <summary>
    /// 91. 解码方法
    /// https://leetcode-cn.com/problems/decode-ways/
    /// </summary>
    public class _00091_解码方法
    {
        /// <summary>
        /// Time:O(N)
        /// Space:O(N)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int len = s.Length;
            int[] dp = new int[len + 1];
            if (s[0] == '0') return 0;
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 1; i < len; i++)
            {
                if (s[i] == '0')
                {
                    if (s[i - 1] == 0)
                        return 0;
                    else if (s[i - 1] == '1' || s[i - 1] == '2')
                        dp[i + 1] = dp[i - 1];
                }
                else if (s[i - 1] == '1' || s[i - 1] == '2' && s[i] > '0' && s[i] < '7')
                {
                    dp[i + 1] = dp[i] + dp[i - 1];
                }
                else
                    dp[i + 1] = dp[i];
            }
            return dp[len];
        }

        /// <summary>
        /// Time:O(N)
        /// Space:O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int NumDecodingsV2(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int len = s.Length;
            int[] dp = new int[2];
            if (s[0] == '0') return 0;
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 1; i < len; i++)
            {
                if (s[i] == '0')
                {
                    if (s[i - 1] == '1' || s[i - 1] == '2')
                        dp[(i + 1) % 2] = dp[(i - 1) % 2];
                    else
                        return 0;
                }
                else if (s[i - 1] == '1' || s[i - 1] == '2' && s[i] > '0' && s[i] < '7')
                {
                    dp[(i + 1) % 2] = dp[i % 2] + dp[(i - 1) % 2];
                }
                else
                    dp[(i + 1) % 2] = dp[i % 2];
            }
            return dp[len % 2];
        }
    }
}
