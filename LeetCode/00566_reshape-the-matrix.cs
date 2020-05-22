using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 566. 重塑矩阵
/// https://leetcode-cn.com/problems/reshape-the-matrix/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00566_reshape_the_matrix
    {
        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            if (nums == null || nums.Length == 0 || nums[0].Length == 0) return nums;
            int rows = nums.Length, cols = nums[0].Length;
            if (r * c != rows * cols) return nums;
            int[][] data = new int[r][];
            for (int i = 0; i < r; i++)
            {
                data[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    int cur = c * i + j + 1;
                    data[i][j] = nums[(cur - 1) / cols][(cur - 1) % cols];
                }
            }
            return data;
        }
    }
}
