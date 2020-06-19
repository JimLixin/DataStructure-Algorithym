/*
309. 最佳买卖股票时机含冷冻期
https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
*/
class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n = prices.size();
        if (n < 2)
            return 0;
        if (n == 2)
            return prices[1] > prices[0] ? prices[1] - prices[0] : 0;
        vector<vector<int>> dp(n, vector<int>(2));
        dp[0][0] = 0;
        dp[0][1] = -prices[0];
        dp[1][0] = max(0, prices[1] - prices[0]);
        dp[1][1] = max(-prices[1], dp[0][1]);
        for (int i = 2; i < n; i++)
        {
            //第i天时没有持有股票，可能是：
            //1.第i天刚卖掉，此时最大利润是第i-1天买入时的利润加上 prices[i]
            //2.第i天是冷冻期，此时最大利润是i-1天卖出时的利润
            dp[i][0] = max(dp[i - 1][1] + prices[i], dp[i - 1][0]);
            //第i天时持有股票，可能是：
            //1.第i天刚买入，此时最大利润是第i-2天卖出时的利润减去 prices[i]
            //2.i之前的一天买入，第i天只是继续持有，则第i-1天也只可能是继续持有的状态，所以利润等于i-1天时的利润
            dp[i][1] = max(dp[i - 2][0] - prices[i], dp[i - 1][1]);
        }
        return dp[n - 1][0];
    }
};