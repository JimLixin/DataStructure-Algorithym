using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 26. 删除排序数组中的重复项
/// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/
/// </summary>
namespace Algorithym.LeetCode
{

    public static class remove_duplicates_from_sorted_array
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
                return 0;
            int bufStart = 1, bufEnd = 1, current = nums[0];
            int n = nums.Length;
            while (bufEnd < n)
            {
                if (current != nums[bufEnd])
                {
                    if (bufEnd > bufStart)
                    {
                        nums[bufStart] = nums[bufEnd];
                    }
                    current = nums[bufEnd];
                    bufStart++;
                }
                bufEnd++;
            }
            return bufStart;
        }
    }
}
