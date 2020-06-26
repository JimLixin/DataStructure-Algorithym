/*
面试题 16.07. 最大数值
https://leetcode-cn.com/problems/maximum-lcci/
*/
class Solution {
public:
    int maximum(int a, int b) {
        long c = a;
        long d = b;
        int res = (int)((fabs(c - d) + c + d) / 2);
        return res;
    }
};