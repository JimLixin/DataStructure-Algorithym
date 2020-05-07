using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 300. 最长上升子序列
/// https://leetcode-cn.com/problems/longest-increasing-subsequence/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 自己想出来的原始版本
    /// </summary>
    public class _00300_longest_increasing_subsequence
    {
        int[] dp;
        int[] _nums;
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            _nums = nums;
            int len = _nums.Length, max = 0;
            dp = new int[len];
            dp[len - 1] = 1;
            max = dp[len - 1];
            for (int i = len - 2; i >= 0; i--)
            {
                int next = findBiggest(i, len);
                dp[i] = next > i ? dp[next] + 1 : 1;
                max = Math.Max(max, dp[i]);
                //Console.WriteLine($"Current _nums[{i}] = {_nums[i]}, nearest bigger one is at index {next}. dp[i] = {dp[i]}, max is {max}");
            }
            return max;
        }

        private int findBiggest(int start, int end)
        {
            int dpMax = -1;
            int index = start;
            for (int i = start + 1; i < end; i++)
            {
                if (_nums[i] > _nums[start] && (dpMax < 0 || dp[i] > dpMax))
                {
                    dpMax = dp[i];
                    index = i;
                }
            }
            return index;
        }
    }

    /// <summary>
    /// 自己优化过的版本
    /// </summary>
    public class _00300_longest_increasing_subsequence_V2
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int len = nums.Length, max = 0;
            int[] dp = new int[len];
            dp[len - 1] = 1;
            max = dp[len - 1];
            for (int i = len - 2; i >= 0; i--)
            {
                int dpMax = -1;
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[j] > nums[i] && (dpMax < 0 || dp[j] > dpMax))
                        dpMax = dp[j];
                }
                dp[i] = dpMax > 0 ? dpMax + 1 : 1;
                max = Math.Max(max, dp[i]);
                //Console.WriteLine($"Current _nums[{i}] = {_nums[i]}, nearest bigger one is at index {next}. dp[i] = {dp[i]}, max is {max}");
            }
            return max;
        }
    }

    /// <summary>
    /// 看题解并优化过的版本
    /// </summary>
    public class _00300_longest_increasing_subsequence_V3
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int len = nums.Length, max = 0;
            int[] dp = new int[len];
            dp[len - 1] = 1;
            max = dp[len - 1];
            for (int i = len - 2; i >= 0; i--)
            {
                dp[i] = 1;
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[j] > nums[i])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
                max = Math.Max(max, dp[i]);
            }
            return max;
        }
    }
}
