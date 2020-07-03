/*
718. 最长重复子数组
https://leetcode-cn.com/problems/maximum-length-of-repeated-subarray/
*/
class Solution {
public:
    //动态规划
    int findLength(vector<int>& A, vector<int>& B) {
        int res = 0, len1 = A.size(), len2 = B.size();
        vector<vector<int>> dp(len1, vector<int>(len2));
        for (int i = 0; i < len1; i++) dp[i][0] = A[i] == B[0];
        for (int i = 0; i < len2; i++) dp[0][i] = A[0] == B[i];
        for (int i = 1; i < len1; i++)
        {
            for (int j = 1; j < len2; j++)
            {
                dp[i][j] = A[i] == B[j] ? dp[i - 1][j - 1] + 1 : 0;
                if (dp[i][j] > res) res = dp[i][j];
            }
        }
        return res;
    }
};