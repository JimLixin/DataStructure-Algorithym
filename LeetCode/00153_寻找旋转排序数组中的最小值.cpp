/*
153. 寻找旋转排序数组中的最小值
https://leetcode-cn.com/problems/find-minimum-in-rotated-sorted-array/
*/
class Solution {
public:
    int findMin(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        return nums[0];
    }

    //二分查找
    int findMinV2(vector<int>& nums) {
        int len = nums.size(), left = 0, right = len - 1, mid = 0;
        if (nums[left] < nums[right]) return nums[left];
        while (right - left > 1)
        {
            mid = left + (right - left) / 2;
            if (nums[mid] < nums[left])
                right = mid;
            else
                left = mid;
        }
        return nums[right];
    }
};