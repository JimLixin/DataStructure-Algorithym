/*
357. 计算各个位数不同的数字个数
https://leetcode-cn.com/problems/count-numbers-with-unique-digits/
*/
class Solution {
public:
    int countNumbersWithUniqueDigits(int n) {
        if (n == 0) return 1;
        int a = 10, b = 81;
        for (int i = 2; i <= n; i++)
        {
            a += b;
            b *= 10 - i;
        }
        return a;
    }
};