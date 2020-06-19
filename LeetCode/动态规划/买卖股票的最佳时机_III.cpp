/*
123. 买卖股票的最佳时机 III
https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-iii/
*/
class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n = prices.size();
        if (n < 2) return 0;

        vector<vector<vector<int>>> dp(n, vector<vector<int>>(2, vector<int>(3, 0)));
        dp[0][0][0] = 0;
        dp[0][1][0] = -prices[0];
        dp[0][0][1] = 0;
        dp[0][0][2] = 0;
        dp[0][1][1] = INT_MIN;
        dp[0][1][2] = INT_MIN;
        for (int i = 1; i < n; i++)
        {
            dp[i][0][0] = 0;
            dp[i][0][1] = max(dp[i - 1][0][1], dp[i - 1][1][0] + prices[i]);
            dp[i][0][2] = max(dp[i - 1][0][2], dp[i - 1][1][1] + prices[i]);
            dp[i][1][0] = max(dp[i - 1][1][0], -prices[i]);
            dp[i][1][1] = max(dp[i - 1][1][1], dp[i - 1][0][1] - prices[i]);
            dp[i][1][2] = INT_MIN;
        }
        return max(0, max(dp[n - 1][0][1], dp[n - 1][0][2]));
    }
};