/*
1281. 整数的各位积和之差
https://leetcode-cn.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
*/
class Solution {
public:
    int subtractProductAndSum(int n) {
        int k = 0, a = 0, b = 1;
        while (n != 0)
        {
            k = n % 10;
            a += k;
            b *= k;
            n /= 10;
        }
        return b - a;
    }
};