/*
762. 二进制表示中质数个计算置位
https://leetcode-cn.com/problems/prime-number-of-set-bits-in-binary-representation/
*/
class Solution {
public:
    int countPrimeSetBits(int L, int R) {
        int res = 0;
        unordered_set<int> primes = { 2,3,5,7,11,13,17,19 };
        for (int i = L; i <= R; i++)
        {
            if (primes.count(getDigits(i)))
                res++;
        }
        return res;
    }

    int getDigits(int num)
    {
        int res = 0;
        while (num != 0)
        {
            num &= num - 1;
            res++;
        }
        return res;
    }
};
