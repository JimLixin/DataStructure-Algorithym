using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 713. 乘积小于K的子数组
/// https://leetcode-cn.com/problems/subarray-product-less-than-k/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00713_subarray_product_less_than_k
    {
        /// <summary>
        /// 暴力解法
        /// 超出时间限制
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int res = 1;
                for (int j = i; j < nums.Length; j++)
                {
                    res = (j == i ? nums[i] : res * nums[j]);
                    if (res >= k) break;
                    count++;
                    //Console.WriteLine($"i:{i}, j:{j},res is {res}");
                }
            }
            return count;
        }

        /// <summary>
        /// 双指针+滑动窗口
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int NumSubarrayProductLessThanKV2(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k <= 1)
                return 0;
            int multiply = 1, count = 0, j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                multiply *= nums[i];
                while (multiply >= k)
                {
                    multiply /= nums[j++];
                }
                count += i - j + 1;
            }
            return count;
        }
    }
}
