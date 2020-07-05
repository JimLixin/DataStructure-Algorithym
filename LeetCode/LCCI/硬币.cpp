/*
面试题 08.11. 硬币
https://leetcode-cn.com/problems/coin-lcci/
*/
class Solution {
private:
    int mod = 1000000007;

public:
    int waysToChange(int n) {
        //dp[i] - 金额为i时有dp[i]中表示法
        //dp[0]: 金额为0时表示法为0
        //dp[i] : sum(dp[i-1], dp[i-5], dp[i-10], dp[i-25])
        vector<int> dp(n + 1);
        int coins[] = { 1,5,10,25 };
        dp[0] = 1;
        for (int i = 0; i < 4; i++)
        {
            for (int j = coins[i]; j <= n; j++)
            {
                dp[j] = (dp[j] + dp[j - coins[i]]) % mod;
                //cout << "dp[" << j << "]: " << dp[j] << endl;
            }
        }
        return dp[n];
    }
};