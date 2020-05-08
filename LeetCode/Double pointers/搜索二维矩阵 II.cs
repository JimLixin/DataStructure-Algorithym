using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 240. 搜索二维矩阵 II
/// https://leetcode-cn.com/problems/search-a-2d-matrix-ii/
/// </summary>
namespace Algorithym.LeetCode.Double_pointers
{
    public class _00240_search_a_2d_matrix_ii
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
                return false;
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            int i = 0, j = cols - 1;
            while (i < rows && j >= 0)
            {
                if (matrix[i, j] == target)
                    return true;
                if (matrix[i, j] > target)
                    j--;
                else
                    i++;
            }
            return false;
        }
    }
}
