using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/n-th-tribonacci-number/
    /// </summary>
    public static class n_th_tribonacci_number
    {
        /// <summary>
        /// Time: O(N)
        /// Space: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Answer(int n)
        {
            int[] result = new int[4];
            result[0] = 0;
            result[1] = 1;
            result[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                result[i % 4] = result[(i - 1) % 4] + result[(i - 2) % 4] + result[(i - 3) % 4];
            }
            return result[n % 4];
        }
    }
}
