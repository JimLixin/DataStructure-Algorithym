/*
413. 等差数列划分
https://leetcode-cn.com/problems/arithmetic-slices/
*/
class Solution {
public:
    //动态规划
    // 时间O(N) 空间O(N)
    int numberOfArithmeticSlices(vector<int>& A) {
        int n = A.size(), len = 2;
        if (n < 3) return 0;
        vector<int> dp(n, 0);
        for (int i = 2; i < n; i++)
        {
            if (A[i] + A[i - 2] == 2 * A[i - 1])
            {
                len = len == 0 ? 3 : len + 1;
                dp[i] = dp[i - 1] + len - 2;
            }
            else
            {
                len = 0;
                dp[i] = dp[i - 1];
            }
        }
        return dp[n - 1];
    }

    //动态规划
    // 时间O(N) 空间O(1)
    int numberOfArithmeticSlicesV2(vector<int>& A) {
        int n = A.size();
        if (n < 3) return 0;
        int k = 2, dp = 0;
        for (int i = k; i < n; i++)
        {
            if (A[i] + A[i - 2] == 2 * A[i - 1])
            {
                k = k == 0 ? 3 : k + 1;
                dp += k - 2;
            }
            else
                k = 0;
        }
        return dp;
    }
};