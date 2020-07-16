/*
315. 计算右侧小于当前元素的个数
https://leetcode-cn.com/problems/count-of-smaller-numbers-after-self/
*/
class Solution {
public:
    vector<int> countSmaller(vector<int>& nums) {
        int n = nums.size();
        vector<int> ans(n);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[j] < nums[i])
                    ans[i]++;
            }
        }
        return ans;
    }
};