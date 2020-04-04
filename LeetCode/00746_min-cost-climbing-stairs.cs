using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class min_cost_climbing_stairs
    {
        public static int Answer(int[] cost)
        {
            if (cost == null || cost.Length == 0)
                return 0;
            int len = cost.Length;
            int[] dp = new int[len];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i < len; i++)
            {
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
            }
            return Math.Min(dp[len - 1], dp[len - 2]);
        }
    }
}
