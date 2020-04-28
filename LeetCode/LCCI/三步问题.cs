using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 面试题 08.01. 三步问题
    /// https://leetcode-cn.com/problems/three-steps-problem-lcci/
    /// </summary>
    public class 三步问题
    {
        public int WaysToStep(int n)
        {
            int[] dp = new int[3];
            dp[0] = 1;
            dp[1] = 2;
            dp[2] = 4;

            if (n < 4) return dp[n - 1];

            for (int i = 3; i < n; i++)
            {
                dp[i % 3] = ((dp[(i - 1) % 3] + dp[(i - 2) % 3]) % 1000000007 + dp[(i - 3) % 3]) % 1000000007;
            }
            return dp[(n - 1) % 3];
        }
    }
}
