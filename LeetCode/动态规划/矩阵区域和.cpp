/*
1314. 矩阵区域和
https://leetcode-cn.com/problems/matrix-block-sum/
*/

//暴力解法
class Solution {
public:
    vector<vector<int>> matrixBlockSum(vector<vector<int>>& mat, int K) {
        int rows = mat.size(), cols = mat[0].size();
        vector<vector<int>> res(rows, vector<int>(cols));
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                res[i][j] = getSum(mat, i, j, K, rows, cols);
            }
        }
        return res;
    }

    int getSum(vector<vector<int>>& mat, int r, int c, int k, int rows, int cols)
    {
        int sum = 0;
        int rleft = max(r - k, 0), rright = min(r + k, rows - 1);
        int cleft = max(c - k, 0), cright = min(c + k, cols - 1);
        for (int i = rleft; i <= rright; i++)
        {
            for (int j = cleft; j <= cright; j++)
            {
                sum += mat[i][j];
            }
        }
        return sum;
    }
};

//二维前缀和
class Solution2 {
public:
    int get(const vector<vector<int>>& pre, int m, int n, int x, int y) {
        x = max(min(x, m), 0);
        y = max(min(y, n), 0);
        return pre[x][y];
    }
    vector<vector<int>> matrixBlockSum(vector<vector<int>>& mat, int K) {
        int m = mat.size(), n = mat[0].size();
        vector<vector<int>> dp(m + 1, vector<int>(n + 1));
        vector<vector<int>> ans(m, vector<int>(n));
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                dp[i][j] = dp[i - 1][j] + dp[i][j - 1] - dp[i - 1][j - 1] + mat[i - 1][j - 1];
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                ans[i][j] = get(dp, m, n, i + K + 1, j + K + 1) - get(dp, m, n, i - K, j + K + 1) - get(dp, m, n, i + K + 1, j - K) + get(dp, m, n, i - K, j - K);
            }
        }
        return ans;
    }

};