using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Dynamic_Progamming
{
    /// <summary>
    /// 给定一个包含非负整数的 m x n 网格，请找出一条从左上角到右下角的路径，使得路径上的数字总和为最小。
    /// 说明：每次只能向下或者向右移动一步。
    /// 举例：
    /// 输入:
    /// arr = [
    /// [1,3,1],
    /// [1,5,1],
    /// [4,2,1]
    /// ]
    /// 输出: 7
    /// 解释: 因为路径 1→3→1→1→1 的总和最小。
    /// </summary>
    public static class Problem3
    {
        public static int Answer(int[,] input)
        {
            int row = input.GetLength(0), col = input.GetLength(1);
            int[,] dp = new int[row, col];

            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    if (i * j == 0)
                    {
                        if (i == 0 && j == 0)
                            dp[j, i] = input[j, i];
                        else
                            dp[j, i] = (i == 0 ? dp[j - 1, i] : dp[j, i - 1]) + input[j, i];
                    }
                    else
                    {
                        dp[j, i] = Math.Min(dp[j - 1, i], dp[j, i - 1]) + input[j, i];
                    }
                }
            }
            return dp[row - 1, col -1];
        }

        /// <summary>
        /// 优化空间复杂度从O(m*n)->O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ImporvedAnswer(int[,] input)
        {
            int row = input.GetLength(0), col = input.GetLength(1);
            int[] dp = new int[col];

            for (int i = 0; i < col; i++)
            {
                dp[i] = (i == 0 ? input[0, 0] : (dp[i - 1] + input[0, i]));
            }

            for (int j = 1; j < row; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    dp[i] = (i == 0 ? dp[0] : Math.Min(dp[i], dp[i - 1])) + input[j, i];
                }
            }
            return dp[col - 1];
        }
    }
}
