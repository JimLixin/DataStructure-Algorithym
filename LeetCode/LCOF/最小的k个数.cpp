/*
剑指 Offer 40. 最小的k个数
https://leetcode-cn.com/problems/zui-xiao-de-kge-shu-lcof/
*/

//桶排序
class Solution {
public:
    vector<int> getLeastNumbers(vector<int>& arr, int k) {
        vector<int> res;
        vector<int> data(10001);
        for (int i = 0; i < arr.size(); i++) data[arr[i]]++;
        for (int i = 0; i < 10001; i++)
        {
            if (data[i] == 0) continue;
            while (data[i] > 0 && k > 0)
            {
                res.push_back(i);
                data[i]--;
                k--;
            }
        }
        return res;
    }
};