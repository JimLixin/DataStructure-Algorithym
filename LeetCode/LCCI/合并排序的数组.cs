using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 面试题 10.01. 合并排序的数组
    /// https://leetcode-cn.com/problems/sorted-merge-lcci/
    /// </summary>
    public class sorted_merge_lcci
    {
        public void Merge(int[] A, int m, int[] B, int n)
        {
            int end = (m + n - 1);
            while (n > 0 && m > 0)
            {
                if (A[m - 1] > B[n - 1])
                {
                    A[end] = A[m - 1];
                    m--;
                }
                else
                {
                    A[end] = B[n - 1];
                    n--;
                }
                end--;
            }
            while (n > 0)
            {
                A[end] = B[n - 1];
                n--;
                end--;
            }
            while (m > 0)
            {
                A[end] = A[m - 1];
                m--;
                end--;
            }
        }
    }
}
