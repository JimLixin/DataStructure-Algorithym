/*
797. 所有可能的路径
https://leetcode-cn.com/problems/all-paths-from-source-to-target/
*/
class Solution {
private:
    vector<int> data;
    vector<vector<int>> res;
public:
    vector<vector<int>> allPathsSourceTarget(vector<vector<int>>& graph) {
        data.push_back(0);
        dfs(graph, 0);
        return res;
    }

    void dfs(vector<vector<int>>& graph, int index)
    {
        if (graph[index].empty())
        {
            res.push_back(data);
            return;
        }
        for (auto n : graph[index])
        {
            data.push_back(n);
            dfs(graph, n);
            data.pop_back();
        }
    }
};