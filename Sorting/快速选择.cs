using Algorithym.LeetCode.Topics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// https://en.wikipedia.org/wiki/Quickselect
/// https://zhuanlan.zhihu.com/p/64627590 看这篇文章秒懂
/// </summary>
namespace Algorithym.Sorting
{
    public class QuickSelect
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            return quickSelect(nums, k, 0, nums.Length - 1);
        }

        public static int quickSelect(int[] nums, int k, int left, int right)
        {
            int pivot = (new Random()).Next(left, right), i = left, j = left;
            swap(nums, pivot, right);
            while (j < right)
            {
                if (nums[j] <= nums[right]) swap(nums, i++, j);
                j++;
            }
            swap(nums, right, i);
            if (i + k - 1 == right)
                return nums[i];
            else if (i + k - 1 > right)
                return quickSelect(nums, k - (right - i + 1), left, i - 1);
            else
                return quickSelect(nums, k, i+1, right);
        }

        private static void swap(int[] nums, int a, int b)
        {
            int tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }
    }
}
