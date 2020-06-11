/*
503. 下一个更大元素 II
https://leetcode-cn.com/problems/next-greater-element-ii/
*/
class Solution {
public:
    vector<int> nextGreaterElements(vector<int>& nums) {
        int len = nums.size();
        vector<int> ans(len, -1);
        stack<int> s;
        for (int i = 2 * len - 1; i >= 0; i--)
        {
            int k = i % len;
            while (!s.empty() && s.top() <= nums[k])
            {
                s.pop();
            }
            if (!s.empty()) ans[k] = s.top();
            s.push(nums[k]);
        }
        return ans;
    }
};