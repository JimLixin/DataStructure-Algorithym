using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.07. 旋转矩阵
/// https://leetcode-cn.com/problems/rotate-matrix-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 旋转矩阵
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return;
            int n = matrix.Length, left = 0, right = n - 1;
            for (int i = 0; i < n; i++)
            {
                left = 0;
                right = n - 1;
                while (left < right)
                {
                    matrix[i][left] = matrix[i][left] ^ matrix[i][right];
                    matrix[i][right] = matrix[i][left] ^ matrix[i][right];
                    matrix[i][left] = matrix[i][left] ^ matrix[i][right];
                    left++;
                    right--;
                }
            }
            for (int i = 0, k = n - 1; i < n; i++, k--)
            {
                for (int j = 0; j < k; j++)
                {
                    matrix[i][j] = matrix[i][j] ^ matrix[n - j - 1][n - i - 1];
                    matrix[n - j - 1][n - i - 1] = matrix[i][j] ^ matrix[n - j - 1][n - i - 1];
                    matrix[i][j] = matrix[i][j] ^ matrix[n - j - 1][n - i - 1];
                }
            }
        }
    }
}
