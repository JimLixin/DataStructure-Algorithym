using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 74. 搜索二维矩阵
/// https://leetcode-cn.com/problems/search-a-2d-matrix/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00074_search_a_2d_matrix
    {
        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return false;
            int rows = matrix.Length, cols = matrix[0].Length;
            int i = 0, j = cols - 1;
            while (i < rows && j >= 0)
            {
                if (matrix[i][j] == target)
                    return true;
                if (matrix[i][j] < target)
                    i++;
                else
                    j--;
            }
            return false;
        }

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrixV2(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return false;
            int rows = matrix.Length, cols = matrix[0].Length;
            int start = 0, end = rows * cols - 1, mid = 0, i = 0, j = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                i = mid / cols;
                j = mid % cols;
                if (matrix[i][j] == target)
                    return true;
                if (matrix[i][j] > target)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return false;
        }
    }
}
