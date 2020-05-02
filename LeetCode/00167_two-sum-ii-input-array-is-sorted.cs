using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 167. 两数之和 II - 输入有序数组
    /// https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    public class two_sum_ii_input_array_is_sorted
    {
        /// <summary>
        /// 普通实现
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return new int[0];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (map.ContainsKey(numbers[i]))
                    return new int[] { map[numbers[i]] + 1, i + 1 };
                else
                {
                    if (!map.ContainsKey(target - numbers[i]))
                        map.Add(target - numbers[i], i);
                }

            }
            return new int[0];
        }

        /// <summary>
        /// 双指针实现
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumV2(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return new int[0];
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                if (target == numbers[left] + numbers[right])
                    return new int[] { left + 1, right + 1 };
                if (target > numbers[left] + numbers[right])
                    left++;
                else
                    right--;
            }
            return new int[0];
        }
    }
}
