using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题57. 和为s的两个数字
    /// https://leetcode-cn.com/problems/he-wei-sde-liang-ge-shu-zi-lcof/
    /// </summary>
    public class he_wei_sde_liang_ge_shu_zi_lcof
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            int[] data = new int[10000000];
            while (nums[i] < target && i < nums.Length)
            {
                if (data[nums[i]] > 0)
                    return new int[] { data[nums[i]], nums[i] };
                data[target - nums[i]] = nums[i];
                i++;
            }
            return new int[] { };
        }
    }
}
