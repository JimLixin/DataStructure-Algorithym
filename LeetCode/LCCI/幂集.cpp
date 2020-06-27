/*
面试题 08.04. 幂集
https://leetcode-cn.com/problems/power-set-lcci/
*/
class Solution {
private:
    vector<int> data;
    vector<vector<int>> res;
public:
    vector<vector<int>> subsets(vector<int>& nums) {
        res.push_back({});
        dfs(nums, 0, 0);
        return res;
    }

    void dfs(vector<int>& nums, int step, int start)
    {
        for (int i = start; i < nums.size(); i++)
        {
            data.push_back(nums[i]);
            res.push_back(data);
            dfs(nums, step + 1, i + 1);
            data.pop_back();
        }
    }
};