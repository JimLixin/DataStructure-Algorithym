/*
162. 寻找峰值
https://leetcode-cn.com/problems/find-peak-element/
*/
class Solution {
public:
    int findPeakElement(vector<int>& nums) {
        return helper(nums, 0, nums.size() - 1);
    }

    int helper(vector<int>& nums, int l, int r)
    {
        if (l == r) return l;
        int mid = l + (r - l) / 2;
        if (nums[mid] > nums[mid + 1])
            return helper(nums, l, mid);
        else
            return helper(nums, mid + 1, r);
    }
};