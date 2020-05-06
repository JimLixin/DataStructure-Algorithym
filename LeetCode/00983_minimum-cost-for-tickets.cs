using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 983. 最低票价
/// https://leetcode-cn.com/problems/minimum-cost-for-tickets/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00983_minimum_cost_for_tickets
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            int len = days.Length, maxDay = days[len - 1], minDay = days[0];
            int[] dp = new int[maxDay + 31];
            for (int cur = maxDay, i = len - 1; i >= 0; cur--)
            {
                if (days[i] == cur)
                {
                    dp[cur] = Math.Min(Math.Min(dp[cur + 1] + costs[0], dp[cur + 7] + costs[1]), dp[cur + 30] + costs[2]);
                    i--;
                }
                else
                    dp[cur] = dp[cur + 1];
            }
            return dp[minDay];
        }
    }
}
