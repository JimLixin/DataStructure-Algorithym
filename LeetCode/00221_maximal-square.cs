using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 221. 最大正方形
    /// https://leetcode-cn.com/problems/maximal-square/
    /// </summary>
    public class maximal_square
    {
        /// <summary>
        /// 暴力解法
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int MaximalSquare(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return 0;
            int maxArea = 0, side = 1, rows = matrix.Length, cols = matrix[0].Length;
            while (side <= rows && side <= cols)
            {
                bool exist = false;
                int tmp;
                for (int i = 0; i < rows - side + 1; i++)
                {
                    for (int j = 0; j < cols - side + 1; j++)
                    {
                        if (side == 1)
                        {
                            if (maxArea == 0 && matrix[i][j] == '1')
                            {
                                exist = true;
                                maxArea = 1;
                            }
                        }
                        else
                        {
                            tmp = ((matrix[i][j] - 48) & (matrix[i][j + 1] - 48) & (matrix[i + 1][j] - 48) & (matrix[i + 1][j + 1] - 48));
                            if (tmp > 0)
                            {
                                exist = true;
                                matrix[i][j] = '1';
                                maxArea = side * side;
                            }
                            else
                            {
                                matrix[i][j] = '0';
                            }
                        }
                    }
                }
                if (!exist) break;
                side++;
            }
            return maxArea;
        }

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
