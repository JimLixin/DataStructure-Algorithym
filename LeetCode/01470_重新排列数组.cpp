/*
1470. 重新排列数组
https://leetcode-cn.com/problems/shuffle-the-array/
*/
class Solution {
public:
    vector<int> shuffle(vector<int>& nums, int n) {
        int len = nums.size(), k = len / 2;;
        vector<int> res = vector<int>(len);
        for (int i = 0; i < k; i++)
        {
            res[2 * i] = nums[i];
            res[2 * i + 1] = nums[i + k];
        }
        return res;
    }
};