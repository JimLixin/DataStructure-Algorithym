/*
面试题 01.05. 一次编辑
https://leetcode-cn.com/problems/one-away-lcci/
*/
class Solution {
public:
    bool oneEditAway(string first, string second) {
        int m = first.size(), n = second.size();
        vector<vector<int>> dp(m + 1, vector<int>(n + 1));
        for (int i = 0; i <= m; i++) dp[i][0] = i;
        for (int i = 0; i <= n; i++) dp[0][i] = i;
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (first[i - 1] == second[j - 1])
                    dp[i][j] = dp[i - 1][j - 1];
                else
                    dp[i][j] = min(dp[i - 1][j - 1], min(dp[i - 1][j], dp[i][j - 1])) + 1;
            }
        }
        return dp[m][n] < 2;
    }
};