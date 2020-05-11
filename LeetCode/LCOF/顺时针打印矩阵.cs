using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题29. 顺时针打印矩阵
/// https://leetcode-cn.com/problems/shun-shi-zhen-da-yin-ju-zhen-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 顺时针打印矩阵
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return new int[0];
            int rows = matrix.Length, cols = matrix[0].Length;
            int left = 0, right = cols - 1, top = 0, bottom = rows - 1, index = 0;
            int[] result = new int[rows * cols];
            while (true)
            {
                for (int i = left; i <= right; i++)
                    result[index++] = matrix[top][i];
                if (++top > bottom) break;
                for (int i = top; i <= bottom; i++)
                    result[index++] = matrix[i][right];
                if (left > --right) break;
                for (int i = right; i >= left; i--)
                    result[index++] = matrix[bottom][i];
                if (--bottom < top) break;
                for (int i = bottom; i >= top; i--)
                    result[index++] = matrix[i][left];
                if (++left > right) break;
            }
            return result;
        }
    }
}
