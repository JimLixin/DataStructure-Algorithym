/*
209. 长度最小的子数组
https://leetcode-cn.com/problems/minimum-size-subarray-sum/
*/
class Solution {
public:
    int minSubArrayLen(int s, vector<int>& nums) {
        if (nums.empty()) return 0;
        int left = 0, right = 0, sum = 0, res = INT_MAX;
        while (right < nums.size())
        {
            sum += nums[right];
            right++;
            while (sum >= s)
            {
                res = min(res, right - left);
                sum -= nums[left];
                left++;
            }
        }
        return res == INT_MAX ? 0 : res;
    }
};