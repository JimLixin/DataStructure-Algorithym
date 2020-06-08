/*
313. 超级丑数
https://leetcode-cn.com/problems/super-ugly-number/
*/
class Solution
{
    public:
    int nthSuperUglyNumber(int n, vector<int>& primes)
    {
        if (n < 2) return n;
        int k = primes.size(), p[k], result[n];
        result[0] = 1;
        for (int i = 0; i < k; i++) p[i] = 0;
        for (int i = 1; i < n; i++)
        {
            int min = INT_MAX, v[k];
            for (int j = 0; j < k; j++)
            {
                v[j] = result[p[j]] * primes[j];
                if (v[j] < min) min = v[j];
            }
            result[i] = min;
            for (int j = 0; j < k; j++)
            {
                if (min == v[j]) p[j]++;
            }
        }
        return result[n - 1];
    }
};