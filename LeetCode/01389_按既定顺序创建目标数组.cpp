/*
1389. 按既定顺序创建目标数组
https://leetcode-cn.com/problems/create-target-array-in-the-given-order/
*/
class Solution {
public:
    vector<int> createTargetArray(vector<int>& nums, vector<int>& index) {
        int n = nums.size();
        vector<int> res;
        for (int i = 0; i < n; i++)
        {
            res.insert(res.begin() + index[i], nums[i]);
        }
        return res;
    }
};