using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Dynamic_Progamming
{
    /// <summary>
    /// 问题描述：一只青蛙一次可以跳上1级台阶，也可以跳上2级。求该青蛙跳上一个n级的台阶总共有多少种跳法。
    /// </summary>
    public static class Problem1
    {
        /// <summary>
        /// 动态规划实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Answer1(int n)
        {
            if (n <= 1)
                return n;

            int[] dp = new int[n+1];
            for (int i = 0; i <= n; i++)
            {
                if (i <= 2)
                    dp[i] = i;
                else
                    dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        /// <summary>
        /// 针对Answer1优化空间复杂度从O(n)->O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ImprovedAnswer1(int n)
        {
            if (n <= 1)
                return n;

            int[] dp = new int[3];
            for (int i = 0; i <= n; i++)
            {
                if (i <= 2)
                    dp[i] = i;
                else
                    dp[i%3] = dp[(i - 1)%3] + dp[(i - 2)%3];
            }

            return dp[n%3];
        }

        /// <summary>
        /// 递归实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Answer2(int n)
        {
            if (n <= 2)
                return n;
            else
                return Answer2(n - 1) + Answer2(n - 2);
        }
    }
}
