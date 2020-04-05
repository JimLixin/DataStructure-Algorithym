using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public static class maximum_subarray
    {
        /// <summary>
        /// Time: O(N*N)
        /// Space: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Answer(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
                return int.MinValue;
            if (nums.Length == 1)
                return nums[0];
            int len = nums.Length;
            int dp = 0;
            int maxSum = int.MinValue;

            for (int i = len - 1; i >= 0; i--)
            {
                for (int j = i; j < len; j++)
                {
                    if (i == j)
                        dp = nums[i];
                    else if (i == j - 1)
                        dp = nums[i] + nums[j];
                    else
                        dp = dp + nums[j];

                    maxSum = Math.Max(maxSum, dp);
                }
            }
            return maxSum;
        }

        /// <summary>
        /// Time: O(N)
        /// Space: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ImprovedAnswer(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
                return int.MinValue;
            if (nums.Length == 1)
                return nums[0];
            int dp = nums[0];
            int maxSum = dp;

            for (int i = 1; i < nums.Length; i++)
            {
                dp = Math.Max(dp + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, dp);
            }
            return maxSum;
        }
    }
}
