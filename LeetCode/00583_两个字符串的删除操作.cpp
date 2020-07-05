/*
583. 两个字符串的删除操作
https://leetcode-cn.com/problems/delete-operation-for-two-strings/
*/
class Solution {
public:
    /*
    思路1：
    将问题转化为"求两个字符串的最长公共子序列"问题，得到子序列长度之后，用两个字符串的总长度减去两倍的子序列长度就是答案。
    */
    int minDistance(string word1, string word2) {
        int m = word1.size(), n = word2.size();
        vector<vector<int>> dp(m + 1, vector<int>(n + 1));
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                else
                    dp[i][j] = max(dp[i - 1][j], dp[i][j - 1]);
            }
        }
        return m + n - 2 * dp[m][n];
    }

    /*
    思路2：
    f[i, j] 表示使s1中前i个字符和s2个前j个字符相同 所需要的最小步数
    1. 如果s1[i]和s2[j]相等 那就那么就不需要删除操作, 那么f[i][j] = f[i-1][j-1];
    2. 如果s1[i]和s2[j]不相等, 那么就需要删除s1, s2中的其中一个, 如果删除s1[i]就像等的话,那么说明从s1[0到i-1]跟 s2[0-j]相等 需要的操作数就是 f[i-1, j]+1.
    如果删除s2[j], 同理一样说明s1[0-i]和s2[0-j-1]相等， 所需要的删除操作数就是f[i, j-1]+1
    下面的情况选择一个最小的情况即可。
    */
    int minDistanceV2(string word1, string word2) {
        int m = word1.size(), n = word2.size();
        vector<vector<int>> dp(m + 1, vector<int>(n + 1));
        for (int i = 0; i <= m; i++) dp[i][0] = i;
        for (int i = 0; i <= n; i++) dp[0][i] = i;
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                    dp[i][j] = dp[i - 1][j - 1];
                else
                    dp[i][j] = min(dp[i - 1][j], dp[i][j - 1]) + 1;
            }
        }
        return dp[m][n];
    }
};