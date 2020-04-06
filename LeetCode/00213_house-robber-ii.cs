using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber-ii/
    /// </summary>
    public class house_robber_ii
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);
            if (nums.Length == 3)
                return Math.Max(nums[2], Math.Max(nums[0], nums[1]));
            int len = nums.Length;
            return Math.Max(_Rob(nums, 0, len - 2), _Rob(nums, 1, len - 1));
        }

        private int _Rob(int[] nums, int start, int end)
        {
            int len = end - start + 1;
            int[] dp = new int[3];
            dp[start] = nums[start];
            dp[start + 1] = Math.Max(nums[start], nums[start + 1]);

            for (int i = start + 2; i <= end; i++)
            {
                dp[i % 3] = Math.Max(dp[(i - 2) % 3] + nums[i], dp[(i - 1) % 3]);
            }

            return dp[end % 3];
        }
    }
}
