/*
1464. 数组中两元素的最大乘积
https://leetcode-cn.com/problems/maximum-product-of-two-elements-in-an-array/
*/
class Solution {
public:
    //桶排序, 耗费额外空间
    int maxProduct(vector<int>& nums) {
        vector<int> data(1001);
        int res = 1, k = 2;
        for (int i = 0; i < nums.size(); i++) data[nums[i]]++;
        for (int i = 1000; i > 0; i--)
        {
            if (data[i] == 0) continue;
            while (data[i] > 0 && k > 0)
            {
                res *= i - 1;
                data[i]--;
                k--;
            }
        }
        return res;
    }

    //不需要额外空间
    int maxProductV2(vector<int>& nums) {
        int a = 0, b = 0;
        for (auto num : nums)
        {
            if (num > a)
            {
                if (a > b)
                    b = a;
                a = num;
            }
            else if (num > b)
                b = num;
        }
        return (a - 1) * (b - 1);
    }
};