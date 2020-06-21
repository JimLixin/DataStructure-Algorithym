using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 70. 爬楼梯
/// https://leetcode-cn.com/problems/climbing-stairs/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public static class climbing_stairs
    {
        /// <summary>
        /// Time complecity: O(N)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Answer(int n)
        {
            int[] dp = new int[3];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i % 3] = dp[(i - 1) % 3] + dp[(i - 2) % 3];
            }
            return dp[n % 3];
        }
    }
}
