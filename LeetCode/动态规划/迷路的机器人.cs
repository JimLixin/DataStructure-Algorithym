using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Dynamic_Progamming
{
    /// <summary>
    /// 面试题 08.02. 迷路的机器人
    /// https://leetcode-cn.com/problems/robot-in-a-grid-lcci/
    /// </summary>
    public class 迷路的机器人
    {
        public IList<IList<int>> PathWithObstacles(int[][] obstacleGrid)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0)
                return result;
            int rows = obstacleGrid.Length, cols = obstacleGrid[0].Length;
            bool[][] dp = new bool[rows][];
            if (obstacleGrid[0][0] == 1) return result;
            for (int i = 0; i < rows; i++)
            {
                dp[i] = new bool[cols];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 && j == 0)
                        dp[i][j] = obstacleGrid[i][j] == 0;
                    else if (i == 0)
                        dp[i][j] = obstacleGrid[i][j] == 0 && dp[i][j - 1];
                    else if (j == 0)
                        dp[i][j] = obstacleGrid[i][j] == 0 && dp[i - 1][j];
                    else
                        dp[i][j] = (dp[i - 1][j] || dp[i][j - 1]) && (obstacleGrid[i][j] == 0);
                }
            }
            if (dp[rows - 1][cols - 1])
            {
                int i = rows - 1, j = cols - 1;
                result.Add(new int[] { i, j });
                while (i > 0 || j > 0)
                {
                    if (i == 0 || j != 0 && !dp[i - 1][j])
                    {
                        result.Add(new int[] { i, j - 1 });
                        j--;
                    }
                    else if (j == 0 || i != 0 && dp[i - 1][j])
                    {
                        result.Add(new int[] { i - 1, j });
                        i--;
                    }
                }
            }
            return result.Reverse().ToList();
        }
    }
}
