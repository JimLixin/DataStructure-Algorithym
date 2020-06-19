using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public static class best_time_to_buy_and_sell_stock
    {
        public static int Answer(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int len = prices.Length, buy = int.MaxValue, sell = 0;

            for (int i = 0; i < len; i++)
            {
                if (prices[i] < buy)
                    buy = prices[i];
                else
                    sell = Math.Max(sell, prices[i] - buy);
            }
            return sell;
        }
    }
}

//动态规划思想 C++实现
/*
class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n = prices.size();
        if(n < 2) return 0;
        vector<vector<int>> dp(n, vector<int>(2));
        dp[0][0] = 0;
        dp[0][1] = -prices[0];
        for(int i = 1; i < n; i++)
        {
            dp[i][0] = max(dp[i-1][0], dp[i-1][1] + prices[i]);
            dp[i][1] = max(dp[i-1][1], - prices[i]);
        }
        return dp[n-1][0];
    }
}; 
*/

//动态规划思想 优化空间复杂度O(1)
/*
class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n = prices.size();
        if(n < 2) return 0;
        int dp00 = 0, dp01 = -prices[0];
        for(int i = 1; i < n; i++)
        {
            dp00 = max(dp00, dp01 + prices[i]);
            dp01 = max(dp01, - prices[i]);
        }
        return dp00;
    }
}; 
*/
