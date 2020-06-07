using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 322. 零钱兑换
/// https://leetcode-cn.com/problems/coin-change/
/// </summary>
namespace Algorithym.LeetCode.Dynamic_Progamming
{
    public class _00322_coin_change
    {
        /// <summary>
        /// 自己想出来的原始版本
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CoinChange(int[] coins, int amount)
        {
            if (amount <= 0) return 0;
            int[] dp = new int[amount + 1];
            for (int i = 0; i <= amount; i++)
            {
                if (coins.Contains(i))
                    dp[i] = 1;
                else
                {
                    dp[i] = int.MaxValue;
                    for (int j = 0; j < coins.Length; j++)
                    {
                        if (i < coins[j] || dp[i - coins[j]] == 0) continue;
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]]);
                    }
                    dp[i] += dp[i] == int.MaxValue ? 0 : 1;
                }
            }
            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }

        /// <summary>
        /// 优化过的版本
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CoinChangeV2(int[] coins, int amount)
        {
            if (amount <= 0) return 0;
            int[] dp = new int[amount + 1];
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                dp[i] = amount + 1;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i >= coins[j] && dp[i - coins[j]] < dp[i])
                        dp[i] = dp[i - coins[j]] + 1;
                }
            }
            return dp[amount] == amount + 1 ? -1 : dp[amount];
        }
    }
}
