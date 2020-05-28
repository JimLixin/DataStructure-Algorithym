using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 面试题49. 丑数
/// https://leetcode-cn.com/problems/chou-shu-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 丑数
    {
        public int NthUglyNumber(int n)
        {
            int[] dp = new int[n];
            dp[0] = 1;
            int a = 0, b = 0, c = 0;
            for (int i = 1; i < n; i++)
            {
                int n2 = dp[a] * 2, n3 = dp[b] * 3, n5 = dp[c] * 5;
                dp[i] = Math.Min(Math.Min(n2, n3), n5);
                if (dp[i] == n2) a++;
                if (dp[i] == n3) b++;
                if (dp[i] == n5) c++;
            }
            return dp[n - 1];
        }
    }
}
