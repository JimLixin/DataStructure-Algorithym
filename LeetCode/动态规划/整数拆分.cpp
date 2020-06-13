/*
343. 整数拆分
https://leetcode-cn.com/problems/integer-break/
*/

/*
数学推导
*/
class Solution
{
public:
    int integerBreak(int n)
    {
        if (n < 1) return 1;
        if (n < 4) return n - 1;
        int a = n / 3, b = n % 3;
        return b == 0 ? pow(3, a) : (b == 1 ? (pow(3, a - 1) * 4) : pow(3, a) * b);
    }
};

/*
动态规划
*/
class Solution2 {
public:
    int integerBreak(int n) {
        if (n < 3) return 1;
        vector<int> dp(n + 1);
        dp[1] = 1; //f(1)
        dp[2] = 1; //f(2)
        for (int i = 3; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                dp[i] = max(dp[i], max((i - j) * j, dp[i - j] * j));
            }
        }
        return dp[n];
    }
};