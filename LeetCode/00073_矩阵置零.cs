using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 73. 矩阵置零
/// https://leetcode-cn.com/problems/set-matrix-zeroes/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00073_set_matrix_zeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return;
            bool row1 = false, col1 = false;
            int rows = matrix.Length, cols = matrix[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (i == 0)
                            row1 = true;
                        if (j == 0)
                            col1 = true;
                        if (i > 0 && j > 0)
                        {
                            matrix[0][j] = 0;
                            matrix[i][0] = 0;
                        }
                    }
                }
            }
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (i == 0 && row1 || j == 0 && col1)
                    {
                        matrix[i][j] = 0;
                    }
                    if (matrix[0][j] == 0 || matrix[i][0] == 0)
                        matrix[i][j] = 0;
                }
            }
            if (row1)
                for (int i = 0; i < cols; i++) matrix[0][i] = 0;
            if (col1)
                for (int i = 0; i < rows; i++) matrix[i][0] = 0;
        }
    }
}
