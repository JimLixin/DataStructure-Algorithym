using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 48. 旋转图像
/// https://leetcode-cn.com/problems/rotate-image/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00048_rotate_image
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return;
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                int left = 0, right = n - 1;
                while (left < right)
                {
                    matrix[i][left] = matrix[i][left] ^ matrix[i][right];
                    matrix[i][right] = matrix[i][left] ^ matrix[i][right];
                    matrix[i][left] = matrix[i][left] ^ matrix[i][right];
                    left++;
                    right--;
                }
            }
            int k = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    int tmp;
                    tmp = matrix[i][j];
                    matrix[i][j] = matrix[n - j - 1][n - i - 1];
                    matrix[n - j - 1][n - i - 1] = tmp;
                }
                k--;
            }
        }
    }
}
