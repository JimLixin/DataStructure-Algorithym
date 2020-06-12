/*
216. 组合总和 III
https://leetcode-cn.com/problems/combination-sum-iii/
*/
class Solution {
public:
    int N, K;
    vector<bool> vis;
    vector<int> data;
    vector<vector<int>> res;
    vector<vector<int>> combinationSum3(int k, int n) {
        K = k;
        N = n;
        vis = vector<bool>(k);
        dfs(0, 1);
        return res;
    }

    void dfs(int step, int start)
    {
        int sum = accumulate(data.begin(), data.end(), 0);
        if (step >= K)
        {
            if (sum == N) res.push_back(data);
            return;
        }
        for (int i = start; i <= 9; i++)
        {
            if (i + sum > N) break;
            if (!vis[step])
            {
                vis[step] = true;
                data.push_back(i);
                dfs(step + 1, i + 1);
                data.pop_back();
                vis[step] = false;
            }
        }
    }
};