using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 279. 完全平方数
/// https://leetcode-cn.com/problems/perfect-squares/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00279_perfect_squares
    {
        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            int sqrtIndex = (int)Math.Sqrt(n) + 1;
            int[] sqrt = new int[sqrtIndex];
            for (int i = 1; i < sqrtIndex; i++)
            {
                sqrt[i] = i * i;
            }
            for (int i = 1; i <= n; i++)
            {
                dp[i] = int.MaxValue;
                for (int j = 1; j < sqrtIndex; j++)
                {
                    if (i < sqrt[j]) break;
                    dp[i] = Math.Min(dp[i], dp[i - sqrt[j]] + 1);
                }
            }
            return dp[n];
        }
    }
}
