/*
172. 阶乘后的零
https://leetcode-cn.com/problems/factorial-trailing-zeroes/
*/
class Solution {
public:
    int trailingZeroes(int n) {
        //return n == 0 ? 0 : n/5 + trailingZeroes(n/5);

        int res = 0;
        while (n > 0)
        {
            n = n / 5;
            res += n;
        }

        return res;
    }
};