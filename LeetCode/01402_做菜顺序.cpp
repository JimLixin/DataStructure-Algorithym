/*
1402. 做菜顺序
https://leetcode-cn.com/problems/reducing-dishes/
*/
class Solution {
public:
    //动态规划思路
    int maxSatisfaction(vector<int>& satisfaction) {
        //dp[i][j] - 前i个元素中选中j个元素可以达到的最大值
        //dp[i][j]: 对于第i个元素, 如果我们选中它，那我们需要知道前面i-1个元素中选中j-1个元素可以达到的最大值， 
        //即dp[i][j] = dp[i-1][j-1] + satisfaction[j]
        //如果我们不选它， 则 dp[i][j] = dp[i-1][j]
        //base case: 
        // j = 0:意味着我们从i个元素中选取0个，最大值只会为0，即dp[i][0] = 0
        // i == j, 我们从前i个元素中选择全部i个得到的最大值，就是 dp[i-1][j-1] + satisfaction[i]
        int n = satisfaction.size(), ans = 0;
        sort(satisfaction.begin(), satisfaction.end());
        vector<vector<int>> dp(n + 1, vector<int>(n + 1));
        dp[1][1] = satisfaction[0];
        for (int i = 2; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0) dp[i][j] = 0;
                else
                {
                    if (i == j)
                        dp[i][j] = dp[i - 1][j - 1] + satisfaction[i - 1] * j;
                    else
                        dp[i][j] = max(dp[i - 1][j - 1] + satisfaction[i - 1] * j, dp[i - 1][j]);
                    ans = max(ans, dp[i][j]);
                }
            }
        }
        return ans;
    }

    //贪心算法思路
    int maxSatisfactionV2(vector<int>& satisfaction) {
        int n = satisfaction.size(), sum = 0, ans = 0;
        vector<int> preSum(n + 1);
        sort(satisfaction.begin(), satisfaction.end());
        for (int i = 1; i <= n; i++)
        {
            preSum[i] = preSum[i - 1] + satisfaction[i - 1];
            sum += satisfaction[i - 1] * i;
        }
        ans = sum;
        for (int i = 0; i < n; i++)
        {
            if (satisfaction[i] >= 0) break;
            sum -= preSum[n] - preSum[i];
            ans = max(ans, sum);
        }
        return ans;
    }
};