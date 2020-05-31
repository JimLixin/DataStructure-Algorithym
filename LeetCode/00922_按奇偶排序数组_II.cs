using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 922. 按奇偶排序数组 II
/// https://leetcode-cn.com/problems/sort-array-by-parity-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00922_按奇偶排序数组_II
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int len = A.Length, p1 = 0, p2 = 1;
            int[] data = new int[1001];
            for (int n = 0; n < len; n++) data[A[n]]++;
            for (int i = 0; i < len; i++)
            {
                if ((i & 1) == 0)
                {
                    while (data[p1] == 0) p1 += 2;
                    A[i] = p1;
                    data[p1]--;
                }
                else
                {
                    while (data[p2] == 0) p2 += 2;
                    A[i] = p2;
                    data[p2]--;
                }
            }
            return A;
        }
    }
}
