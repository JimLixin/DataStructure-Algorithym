/*
448. 找到所有数组中消失的数字
https://leetcode-cn.com/problems/find-all-numbers-disappeared-in-an-array/
*/
class Solution {

public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
        int pos = 0, n = nums.size();
        vector<int> ans;
        while (pos < n)
        {
            if (nums[pos] == pos + 1 || nums[pos] == nums[nums[pos] - 1])
            {
                pos++;
                continue;
            }
            int tmp1 = nums[pos], tmp2 = nums[nums[pos] - 1];
            nums[nums[pos] - 1] = tmp1;
            nums[pos] = tmp2;
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                ans.push_back(i + 1);
        }
        return ans;
    }
};