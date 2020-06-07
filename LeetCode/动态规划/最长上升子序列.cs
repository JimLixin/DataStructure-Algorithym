using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Dynamic_Progamming
{
    public class 最长上升子序列
    {
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
}
