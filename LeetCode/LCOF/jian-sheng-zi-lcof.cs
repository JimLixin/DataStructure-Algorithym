using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题14- I. 剪绳子
    /// https://leetcode-cn.com/problems/jian-sheng-zi-lcof/
    /// </summary>
    public class jian_sheng_zi_lcof
    {
        /// <summary>
        /// 数学推导法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CuttingRope(int n)
        {
            if (n < 4) return n == 3 ? 2 : 1;
            int threeCount = n / 3, remain = n % 3, factor = (remain == 1 ? 4 : (remain == 2 ? remain : 1));
            return (int)Math.Pow(3, threeCount + (remain == 1 ? -1 : 0)) * factor;
        }

        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CuttingRopeV2(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    dp[i] = Math.Max(dp[i], Math.Max((i - j) * j, j * dp[i - j]));
                }
            }
            return dp[n];
        }
    }
}
