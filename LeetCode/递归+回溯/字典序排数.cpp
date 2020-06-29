/*
386. 字典序排数
https://leetcode-cn.com/problems/lexicographical-numbers/
*/
class Solution {
public:
    vector<int> lexicalOrder(int n) {
        vector<int> res;
        dfs(res, n, 0);
        return res;
    }

    void dfs(vector<int>& res, int N, int val)
    {
        if (val > N) return;
        int s = 0;
        for (int i = 0; i < 10; i++)
        {
            s = i + val;
            if (s == 0) continue;
            if (s > N) break;
            res.push_back(s);
            dfs(res, N, s * 10);
        }
    }
};