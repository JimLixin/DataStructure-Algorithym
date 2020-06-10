using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 674. 最长连续递增序列
/// https://leetcode-cn.com/problems/longest-continuous-increasing-subsequence/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00674_最长连续递增序列
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int max = 1, len = nums.Length;
            int[] dp = new int[len];
            for (int i = 0; i < len; i++) dp[i] = 1;
            for (int i = 1; i < len; i++)
            {
                if (nums[i] > nums[i - 1])
                    dp[i] = dp[i - 1] + 1;
                if (dp[i] > max)
                    max = dp[i];
            }
            return max;
        }
    }
}
