/*
204. 计数质数
https://leetcode-cn.com/problems/count-primes/
*/
class Solution {
public:
    int countPrimes(int n) {
        if (n < 1) return n;
        int result = 0;
        bool data[n];
        for (int i = 0; i < n; i++) data[i] = true;
        for (int i = 2; i * i < n; i++)
        {
            if (data[i])
                for (int j = 2 * i; j < n; j += i) data[j] = false;
        }
        for (int i = 2; i < n; i++) result += data[i] ? 1 : 0;
        return result;
    }
};