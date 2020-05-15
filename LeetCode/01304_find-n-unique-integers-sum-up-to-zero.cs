using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1304. 和为零的N个唯一整数
/// https://leetcode-cn.com/problems/find-n-unique-integers-sum-up-to-zero/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01304_find_n_unique_integers_sum_up_to_zero
    {
        public int[] SumZero(int n)
        {
            int left = 0, right = 0, index = 0;
            int[] result = new int[n];
            if ((n & 1) == 0)
            {
                left = -1;
                right = 1;
            }
            while (index < n)
            {
                result[index++] = left;
                if (left != right)
                    result[index++] = right;
                left--;
                right++;
            }
            return result;
        }
    }
}
