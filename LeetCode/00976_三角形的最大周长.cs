using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 976. 三角形的最大周长
/// https://leetcode-cn.com/problems/largest-perimeter-triangle/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00976_三角形的最大周长
    {
        public int LargestPerimeter(int[] A)
        {
            int max = 0;
            Array.Sort(A);
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i - 2] + A[i - 1] > A[i])
                    max = Math.Max(max, A[i - 2] + A[i - 1] + A[i]);
            }
            return max;
        }
    }
}
