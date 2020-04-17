using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber/
    /// </summary>
    public class house_robber
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];

            int len = nums.Length;
            int[] dp = new int[3];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < len; i++)
            {
                dp[i % 3] = Math.Max(dp[(i - 2) % 3] + nums[i], dp[(i - 1) % 3]);
            }

            return dp[(len - 1) % 3];
        }
    }
}
