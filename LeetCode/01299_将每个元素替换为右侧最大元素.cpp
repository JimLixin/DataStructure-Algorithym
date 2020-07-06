/*
1299. 将每个元素替换为右侧最大元素
https://leetcode-cn.com/problems/replace-elements-with-greatest-element-on-right-side/
*/
class Solution {
public:
    vector<int> replaceElements(vector<int>& arr) {
        int n = arr.size(), max = arr[n - 1];
        vector<int> res(arr.size(), -1);
        for (int i = n - 2; i >= 0; --i)
        {
            res[i] = max;
            if (arr[i] > max) max = arr[i];
        }
        return res;
    }
};