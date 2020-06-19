/*
714. 买卖股票的最佳时机含手续费
https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/
*/
class Solution {
public:
    //常规动态规划解法
    int maxProfit(vector<int>& prices, int fee) {
        int n = prices.size();
        if (n < 2) return 0;
        vector<vector<int>> dp(n, vector<int>(2));
        dp[0][0] = 0;
        dp[0][1] = -prices[0];
        for (int i = 1; i < n; i++)
        {
            dp[i][0] = max(dp[i - 1][0], dp[i - 1][1] + prices[i] - fee);
            dp[i][1] = max(dp[i - 1][1], dp[i - 1][0] - prices[i]);
        }
        return dp[n - 1][0];
    }

    //优化空间复杂度至O(1)
    int maxProfitV2(vector<int>& prices, int fee) {
        int n = prices.size();
        if (n < 2) return 0;
        int a = 0, b = -prices[0];
        for (int i = 1; i < n; i++)
        {
            a = max(a, b + prices[i] - fee);
            b = max(b, a - prices[i]);
        }
        return a;
    }
};