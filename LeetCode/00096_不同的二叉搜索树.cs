using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 96. 不同的二叉搜索树
/// https://leetcode-cn.com/problems/unique-binary-search-trees/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00096_不同的二叉搜索树
    {
        public int NumTrees(int n)
        {
            if (n < 2) return 1;
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    dp[i] += dp[j - 1] * dp[i - j];
                }
            }
            return dp[n];
        }
    }
}
