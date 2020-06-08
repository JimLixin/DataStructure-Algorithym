/*
264. 丑数 II
https://leetcode-cn.com/problems/ugly-number-ii/
*/
class Solution {
public:
    int nthUglyNumber(int n) {
        if (n < 2) return n;
        int data[n], p2 = 0, p3 = 0, p5 = 0;
        data[0] = 1;
        for (int i = 1; i < n; i++)
        {
            int t2 = data[p2] * 2;
            int t3 = data[p3] * 3;
            int t5 = data[p5] * 5;
            int minVal = min(min(t2, t3), t5);
            data[i] = minVal;
            if (minVal == t2) p2++;
            if (minVal == t3) p3++;
            if (minVal == t5) p5++;
        }
        return data[n - 1];
    }

};