using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 33. Search in Rotated Sorted Array
/// https://leetcode-cn.com/problems/search-in-rotated-sorted-array/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00033_search_in_rotated_sorted_array
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int mid = -1, start = 0, end = nums.Length - 1;
            while (end - start > 1)
            {
                mid = (start + end) / 2;
                if (nums[mid] > nums[start])
                    start = mid;
                else
                    end = mid;
            }
            int index1 = binarySearch(nums, 0, end - 1, target);
            int index2 = binarySearch(nums, end, nums.Length - 1, target);
            if (index1 < 0 && index2 < 0) return -1;
            return index1 < 0 ? index2 : index1;
        }

        public int binarySearch(int[] nums, int start, int end, int target)
        {
            int mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] > target)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }
    }
}
