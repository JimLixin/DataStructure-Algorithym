using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths-ii/
    /// </summary>
    public class unique_paths_ii
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0)
                return 0;
            int n = obstacleGrid.Length;
            int m = obstacleGrid[0].Length;
            int[] dp = new int[m];
            for (int i = 0; i < m; i++)
            {
                if (obstacleGrid[0][i] == 1)
                    break;
                dp[i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                        dp[j] = 0;
                    else
                        dp[j] = (j == 0 ? (dp[j] == 0 ? 0 : 1) : (dp[j] + dp[j - 1]));
                }
            }
            return dp[m - 1];
        }
    }
}
