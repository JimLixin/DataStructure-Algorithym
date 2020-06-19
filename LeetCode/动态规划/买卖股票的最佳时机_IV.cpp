/*
188. 买卖股票的最佳时机 IV
https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-iv/
*/
class Solution {
public:
    int maxProfit(int k, vector<int>& prices) {
        int n = prices.size();
        long profit = 0;
        if (n < 2) return 0;
        if (k > n / 2) return maxProfitOfII(prices);
        vector<vector<vector<long>>> dp(n, vector<vector<long>>(2, vector<long>(k + 1, 0)));
        for (int i = 0; i < k; i++)
        {
            if (i == 0)
            {
                dp[0][0][i] = 0;
                dp[0][1][i] = -prices[0];
            }
            else
            {
                dp[0][0][i] = INT_MIN;
                dp[0][1][i] = INT_MIN;
            }
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j <= k; j++)
            {
                dp[i][0][j] = j == 0 ? 0 : max<long>(dp[i - 1][0][j], dp[i - 1][1][j - 1] + prices[i]);
                dp[i][1][j] = j == k ? INT_MIN : max<long>(dp[i - 1][1][j], dp[i - 1][0][j] - prices[i]);
                if (i == n - 1 && dp[i][0][j] > profit) profit = dp[i][0][j];
            }
        }
        return profit;
    }

    int maxProfitOfII(vector<int>& prices) {
        int res = 0;
        for (int i = 1; i < prices.size(); i++) {
            if (prices[i] > prices[i - 1]) {
                res += prices[i] - prices[i - 1];
            }
        }
        return res;
    }
};