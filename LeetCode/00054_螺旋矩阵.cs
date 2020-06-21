using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 54. 螺旋矩阵
/// https://leetcode-cn.com/problems/spiral-matrix/
/// </summary>
namespace Algorithym.LeetCode
{

    public class spiral_matrix
    {
        IList<int[]> result;
        public IList<int> SpiralOrder(int[][] matrix)
        {
            result = new List<int[]>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return new int[] { };
            int height = matrix.Length, width = matrix[0].Length, top = 0, left = 0;
            while (height > 0 && width > 0)
            {
                if (width == 1 && height == 1)
                {
                    (result as List<int[]>).Add(new int[] { top, left });
                    break;
                }
                else if (width == 1)
                {
                    (result as List<int[]>).AddRange(Enumerable.Range(top, height).Select(i => new int[] { i, (left) }));
                    break;
                }
                else if (height == 1)
                {
                    (result as List<int[]>).AddRange(Enumerable.Range(left, width).Select(i => new int[] { top, i }));
                    break;
                }
                (result as List<int[]>).AddRange(Enumerable.Range(left, width - 1).Select(i => new int[] { top, i }));
                (result as List<int[]>).AddRange(Enumerable.Range(top, height - 1).Select(i => new int[] { i, (left + width - 1) }));
                (result as List<int[]>).AddRange(Enumerable.Range(left + 1, width - 1).Reverse().Select(i => new int[] { (top + height - 1), i }));
                (result as List<int[]>).AddRange(Enumerable.Range(top + 1, height - 1).Reverse().Select(i => new int[] { i, left }));
                top++;
                left++;
                width -= 2;
                height -= 2;
            }
            int count = 0;
            Array.ForEach(result.ToArray(), i => {
                matrix[i[0]][i[1]] = count++;
            });
            return result.Select(i => matrix[i[0]][i[1]]).ToList();
        }
    }
}
