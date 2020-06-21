using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 62. 不同路径
/// https://leetcode-cn.com/problems/unique-paths/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class unique_paths
    {
        public int UniquePaths(int m, int n)
        {
            int[] dp = new int[m];
            for (int i = 0; i < m; i++)
            {
                dp[i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[j] = (j == 0 ? 1 : (dp[j] + dp[j - 1]));
                }
            }
            return dp[m - 1];
        }
    }
}
