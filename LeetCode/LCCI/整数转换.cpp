/*
面试题 05.06. 整数转换
https://leetcode-cn.com/problems/convert-integer-lcci/
*/
class Solution {
public:
    int convertInteger(int A, int B) {
        unsigned int n = A ^ B, res = 0;
        while (n != 0)
        {
            res++;
            n &= n - 1;
        }
        return res;
    }
};