using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题59 - I. 滑动窗口的最大值
/// https://leetcode-cn.com/problems/hua-dong-chuang-kou-de-zui-da-zhi-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 滑动窗口的最大值
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];
            int len = nums.Length;
            int max = int.MinValue;
            int[] left = new int[len];
            int[] right = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (i % k == 0)
                    max = int.MinValue;
                max = Math.Max(max, nums[i]);
                left[i] = max;
            }
            max = int.MinValue;
            for (int i = len - 1; i >= 0; i--)
            {
                if (i % k == k - 1)
                    max = int.MinValue;
                max = Math.Max(max, nums[i]);
                right[i] = max;
            }
            int index = 0;
            int[] dp = new int[len - k + 1];
            for (int i = 0; i <= len - k; i++)
            {
                dp[index] = Math.Max(left[i + k - 1], right[i]);
                index++;
            }
            return dp;
        }
    }
}
