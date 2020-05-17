using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1365. 有多少小于当前数字的数字
/// https://leetcode-cn.com/problems/how-many-numbers-are-smaller-than-the-current-number/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01365_how_many_numbers_are_smaller_than_the_current_number
    {
        /// <summary>
        /// 暴力方法 : O(N2)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[j] < nums[i])
                        count++;
                }
                result[i] = count;
            }
            return result;
        }

        /// <summary>
        /// 频次数组+前缀和
        /// 执行用时 :280 ms, 在所有 C# 提交中击败了99.01%的用户
        /// 内存消耗 :31.8 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SmallerNumbersThanCurrentV2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            int len = nums.Length;
            int[] result = new int[len];
            int[] buckets = new int[101];
            for (int i = 0; i < len; i++) buckets[nums[i]]++;
            for (int i = 1; i < 101; i++) buckets[i] += buckets[i - 1];
            for (int i = 0; i < len; i++)
            {
                result[i] = nums[i] > 0 ? buckets[nums[i] - 1] : 0;
            }
            return result;
        }
    }
}
