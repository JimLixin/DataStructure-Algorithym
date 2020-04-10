using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-path-sum/
    /// </summary>
    public class minimum_path_sumcs
    {
        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;
            int row = grid.Length;
            int col = grid[0].Length;

            int[] dp = new int[col];
            for (int i = 0; i < col; i++)
            {
                dp[i] = (i == 0 ? grid[0][i] : dp[i - 1] + grid[0][i]);
            }
            for (int r = 1; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dp[c] = (c == 0 ? dp[c] : Math.Min(dp[c], dp[c - 1])) + grid[r][c];
                }
            }
            return dp[col - 1];
        }
    }
}
