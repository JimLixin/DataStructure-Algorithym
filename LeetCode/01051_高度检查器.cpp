/*
1051. 高度检查器
https://leetcode-cn.com/problems/height-checker/
*/
class Solution {
public:
    int heightChecker(vector<int>& heights) {
        int res = 0;
        vector<int> data(heights.begin(), heights.end());
        sort(data.begin(), data.end());
        for (int i = 0; i < data.size(); i++)
        {
            if (data[i] != heights[i]) res++;
        }
        return res;
    }
};