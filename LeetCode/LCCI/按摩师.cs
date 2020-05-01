using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 面试题 17.16. 按摩师
    /// https://leetcode-cn.com/problems/the-masseuse-lcci/
    /// </summary>
    public class 按摩师
    {
        public int Massage(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int len = nums.Length;
            if (len == 1) return nums[0];
            if (len < 3) return Math.Max(nums[0], nums[1]);
            int[] dp = new int[3];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < len; i++)
            {
                dp[i % 3] = Math.Max(nums[i] + dp[(i - 2) % 3], dp[(i - 1) % 3]);
            }
            return dp[(len - 1) % 3];
        }
    }
}
