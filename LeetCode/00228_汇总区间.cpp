/*
228. 汇总区间
https://leetcode-cn.com/problems/summary-ranges/
*/
class Solution {
public:
    vector<string> summaryRanges(vector<int>& nums) {
        int left = 0, right = 0;
        vector<string> res;
        if (nums.size() == 0) return res;
        for (int i = 1; i < nums.size(); i++)
        {
            if (((long)nums[i] - (long)nums[i - 1]) == 1)
                right++;
            else
            {
                res.push_back(left == right ? to_string(nums[left]) : to_string(nums[left]) + "->" + to_string(nums[right]));
                left = right = i;
            }
        }
        res.push_back(left == right ? to_string(nums[left]) : to_string(nums[left]) + "->" + to_string(nums[right]));
        return res;
    }
};