using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 59. 螺旋矩阵 II
/// https://leetcode-cn.com/problems/spiral-matrix-ii/
/// </summary>
namespace Algorithym.LeetCode
{

    public class spiral_matrix_ii
    {
        /// <summary>
        /// Need to improve!!!
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[][] GenerateMatrix(int n)
        {
            if (n <= 0)
                return new int[0][];
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            List<int[]> positions = new List<int[]>();
            int top = 0, left = 0, count = 1;
            while (n > 0)
            {
                if (n == 1)
                {
                    (positions as List<int[]>).Add(new int[] { top, left });
                    break;
                }
                (positions as List<int[]>).AddRange(Enumerable.Range(left, n - 1).Select(i => new int[] { top, i }));
                (positions as List<int[]>).AddRange(Enumerable.Range(top, n - 1).Select(i => new int[] { i, (left + n - 1) }));
                (positions as List<int[]>).AddRange(Enumerable.Range(left + 1, n - 1).Reverse().Select(i => new int[] { (top + n - 1), i }));
                (positions as List<int[]>).AddRange(Enumerable.Range(top + 1, n - 1).Reverse().Select(i => new int[] { i, left }));
                top++;
                left++;
                n -= 2;
            }

            Array.ForEach(positions.ToArray(), i => {
                matrix[i[0]][i[1]] = count++;
            });
            return matrix;
        }
    }
}
