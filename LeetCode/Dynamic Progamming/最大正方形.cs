using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Dynamic_Progamming
{
    public class 最大正方形
    {
        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int MaximalSquareV2(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return 0;
            int maxSide = 0, rows = matrix.Length, cols = matrix[0].Length;
            int[][] dp = new int[rows + 1][];
            for (int i = 0; i < rows + 1; i++)
            {
                dp[i] = new int[cols + 1];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == '1')
                        dp[i + 1][j + 1] = Math.Min(Math.Min(dp[i][j + 1], dp[i][j]), dp[i + 1][j]) + 1;
                    maxSide = Math.Max(maxSide, dp[i + 1][j + 1]);
                }
            }
            return maxSide * maxSide;
        }
    }
}
