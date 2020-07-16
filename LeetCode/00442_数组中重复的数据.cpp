/*
442. 数组中重复的数据
https://leetcode-cn.com/problems/find-all-duplicates-in-an-array/
*/
class Solution {
public:
    //时间复杂度: O(N)
    //空间复杂度: O(N)
    vector<int> findDuplicates(vector<int>& nums) {
        int n = nums.size();
        vector<int> data(n);
        vector<int> ans;
        for (int i = 0; i < n; ++i) data[nums[i] - 1]++;
        for (int i = 0; i < n; ++i)
        {
            if (data[i] > 1) ans.push_back(i + 1);
        }
        return ans;
    }
};