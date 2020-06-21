using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 34. 在排序数组中查找元素的第一个和最后一个位置
/// https://leetcode-cn.com/problems/find-first-and-last-position-of-element-in-sorted-array/
/// </summary>
namespace Algorithym.LeetCode
{

    public static class find_first_and_last_position_of_element_in_sorted_array
    {
        public static int[] Answer(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return new int[] { -1, -1 };
            return findFirstLast(nums, target, 0, nums.Length - 1);
        }

        public static int[] findFirstLast(int[] nums, int target, int start, int end)
        {
            if (start > end)
                return new int[] { -1, -1};
            int first = -1, last = -1, mid = -1;
            while (end > start)
            {
                mid = (end + start) / 2;
                if (nums[mid] == target)
                {
                    first = mid;
                    last = mid;
                    var result1 = findFirstLast(nums, target, start, mid - 1);
                    var result2 = findFirstLast(nums, target, mid + 1, end);
                    
                    return new int[] { result1[0] > -1 ? result1[0] : first, result2[1] > -1 ? result2[1] : last};
                }
                if (target > nums[mid])
                    start = mid + 1;
                else
                    end = mid;
            }
            if (nums[start] == target)
            {
                first = start;
                last = start;
            }
            return new int[] { first, last };
        }
    }
}
