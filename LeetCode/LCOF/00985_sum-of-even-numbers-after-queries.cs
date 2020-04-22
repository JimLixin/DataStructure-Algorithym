using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-even-numbers-after-queries/
    /// </summary>
    public class sum_of_even_numbers_after_queries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int len = queries.Length, tmp, incre, index, added, sum = A.Where(a => a % 2 == 0).Sum();
            int[] data = new int[len];
            for (int i = 0; i < len; i++)
            {
                index = queries[i][1];
                incre = queries[i][0];
                tmp = A[index] + incre;
                added = (A[index] % 2 == 0 ? (tmp % 2 == 0 ? incre : -A[index]) : (tmp % 2 == 0 ? tmp : 0));
                data[i] = sum + added;
                sum += added;
                //Console.WriteLine("A is:" + string.Join(",", A) + $" A[{index}] is {A[index]}, now add by {incre}. Sum will change from {sum} to {data[i]}.");
                A[index] = tmp;
            }
            return data;
        }
    }
}
