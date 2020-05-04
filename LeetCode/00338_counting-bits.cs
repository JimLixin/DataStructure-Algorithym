using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 338. 比特位计数
    /// https://leetcode-cn.com/problems/counting-bits/
    /// </summary>
    public class _00338_counting_bits
    {
        public int[] CountBits(int num)
        {
            if (num < 0) return new int[0];
            int len = num + 1, count = 1, start = 0;
            int[] dp = new int[len];
            dp[0] = 0;
            for (int i = 1; i < len; i++)
            {
                if ((i & 1) > 0)
                    dp[i] = dp[i - 1] + 1;
                else if ((i & (i - 1)) == 0)
                {
                    dp[i] = 1;
                    count = 1;
                    start = i;
                }
                else
                    dp[i] = count + dp[i - start];
            }
            return dp;
        }
    }
}
