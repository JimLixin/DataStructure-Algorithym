using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 面试题 16.17. 连续数列
    /// https://leetcode-cn.com/problems/contiguous-sequence-lcci/
    /// </summary>
    public class 连续数列
    {
        public int MaxSubArray(int[] nums)
        {
            int cur = nums[0], sum = cur;
            for (int i = 1; i < nums.Length; i++)
            {
                cur = cur > 0 ? cur + nums[i] : nums[i];
                if (cur > sum)
                    sum = cur;
            }
            return sum;
        }
    }
}
