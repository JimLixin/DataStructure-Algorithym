using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 977. 有序数组的平方
    /// https://leetcode-cn.com/problems/squares-of-a-sorted-array/
    /// </summary>
    public class squares_of_a_sorted_array
    {
        public int[] SortedSquares(int[] A)
        {
            int[] data = new int[A.Length];
            int left = 0, right = A.Length - 1, index = right;
            while (left <= right)
            {
                if (A[left] <= 0) left++;
                if (A[right] > 0) right--;
            }
            if (left == 0) return A.Select(a => a * a).ToArray();
            if (right == A.Length - 1) return A.Reverse().Select(a => a * a).ToArray();
            int p1 = left - 1, p2 = left, ind = 0;
            while (p1 >= 0 || p2 < A.Length)
            {
                if (p2 >= A.Length || (p1 >= 0 && A[p1] * A[p1] <= A[p2] * A[p2]))
                {
                    data[ind] = A[p1] * A[p1];
                    p1--;
                    ind++;
                    continue;
                }
                if (p1 < 0 || (p2 < A.Length && A[p1] * A[p1] > A[p2] * A[p2]))
                {
                    data[ind] = A[p2] * A[p2];
                    p2++;
                    ind++;
                }
            }
            return data;
        }
    }
}
