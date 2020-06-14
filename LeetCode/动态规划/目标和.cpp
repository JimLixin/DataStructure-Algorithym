/*
494. 目标和
https://leetcode-cn.com/problems/target-sum/
*/

/*
回溯
执行用时 :1964 ms, 在所有 C++ 提交中击败了6.46%的用户
内存消耗 :8.9 MB, 在所有 C++ 提交中击败了35.29%的用户
*/
class Solution {
public:
    int findTargetSumWays(vector<int>& nums, int S) {
        return dfs(nums, 0, 0, S);
    }

    int dfs(vector<int>& nums, int step, int sum, int S)
    {
        if (step >= nums.size())
            return sum == S ? 1 : 0;
        int v1 = dfs(nums, step + 1, sum + nums[step], S);
        int v2 = dfs(nums, step + 1, sum - nums[step], S);
        return v1 + v2;
    }
};

/*
动态规划
执行用时 :68 ms, 在所有 C++ 提交中击败了57.20%的用户
内存消耗 :22 MB, 在所有 C++ 提交中击败了11.76%的用户
*/
class Solution2 {
public:
    int findTargetSumWays(vector<int>& nums, int S) {
        if (nums.size() == 0) return 0;
        int n = nums.size();
        int sum = accumulate(nums.begin(), nums.end(), 0);
        if (abs(sum) < abs(S)) return 0;
        vector<vector<int>> dp(n, vector<int>(sum * 2 + 1));
        if (nums[0] == 0)
            dp[0][sum] = 2;
        else
        {
            dp[0][sum + nums[0]] = 1;
            dp[0][sum - nums[0]] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < sum * 2 + 1; j++)
            {
                int l = (j - nums[i]) >= 0 ? j - nums[i] : 0;
                int r = (j + nums[i]) < (sum * 2 + 1) ? j + nums[i] : 0;
                dp[i][j] = dp[i - 1][l] + dp[i - 1][r];
            }
        }
        return dp[n - 1][sum + S];
    }
};