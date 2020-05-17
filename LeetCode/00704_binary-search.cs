using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 704. 二分查找
/// https://leetcode-cn.com/problems/binary-search/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00704_binary_search
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + ((end - start) >> 1);
                if (nums[mid] > target)
                    end = mid - 1;
                else if (nums[mid] < target)
                    start = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
