using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题42. 连续子数组的最大和
    /// https://leetcode-cn.com/problems/lian-xu-zi-shu-zu-de-zui-da-he-lcof/
    /// </summary>
    public class _042_连续子数组的最大和
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int cur = nums[0], max = cur;
            for (int i = 1; i < nums.Length; i++)
            {
                cur = cur > 0 ? cur + nums[i] : nums[i];
                max = Math.Max(max, cur);
            }
            return max;
        }
    }
}
