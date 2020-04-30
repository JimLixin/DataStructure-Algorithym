using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题47. 礼物的最大价值
    /// https://leetcode-cn.com/problems/li-wu-de-zui-da-jie-zhi-lcof/
    /// </summary>
    public class 礼物的最大价值
    {
        public int MaxValue(int[][] grid)
        {
            int row = grid.Length, col = grid[0].Length;
            int[] dp = new int[col];
            dp[0] = grid[0][0];
            for (int i = 1; i < col; i++)
            {
                dp[i] = grid[0][i] + dp[i - 1];
            }
            for (int i = 1; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dp[j] = (j == 0 ? (grid[i][0] + dp[j]) : (Math.Max(dp[j - 1], dp[j]) + grid[i][j]));
                }
            }
            return dp[col - 1];
        }
    }
}
