/*
978. 最长湍流子数组
https://leetcode-cn.com/problems/longest-turbulent-subarray/
*/
class Solution {
public:
    //滑动窗口思路
    int maxTurbulenceSize(vector<int>& A) {
        int n = A.size();
        if (n == 1) return 1;
        if (n == 2) return A[0] == A[1] ? 1 : 2;
        int left = 0, right = 2, res = A[0] == A[1] ? 1 : 2, flag = A[0] < A[1] ? -1 : 1;
        while (right < A.size())
        {
            int tmp = (A[right - 1] - A[right]) * flag;
            flag = A[right - 1] < A[right] ? -1 : 1;
            if (tmp < 0)
                res = max(res, right - left + 1);
            else
                left = right + (tmp > 0 ? -1 : 0);
            right++;
        }
        return res;
    }

    //动态规划思路
    int maxTurbulenceSizeV2(vector<int>& A) {
        int n = A.size();
        if (n == 1) return 1;
        if (n == 2) return A[0] == A[1] ? 1 : 2;
        vector<int> dp(n);
        dp[0] = 1;
        dp[1] = A[0] == A[1] ? 1 : 2;
        int res = max(dp[0], dp[1]);
        for (int i = 2; i < n; i++)
        {
            if (A[i - 2] < A[i - 1] && A[i - 1] > A[i] || A[i - 2] > A[i - 1] && A[i - 1] < A[i])
            {
                dp[i] = dp[i - 1] + 1;
                res = max(res, dp[i]);
            }
            else
                dp[i] = A[i - 1] == A[i] ? 1 : 2;
        }
        return res;
    }
};