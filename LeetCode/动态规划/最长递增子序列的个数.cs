using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 673. 最长递增子序列的个数
/// https://leetcode-cn.com/problems/number-of-longest-increasing-subsequence/
/// </summary>
namespace Algorithym.LeetCode.动态规划
{
    public class _00673_最长递增子序列的个数
    {
        public int FindNumberOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int max = -1, count = 0, len = nums.Length;
            int[] dp = new int[len], counter = new int[len];
            for (int i = 0; i < len; i++)
            {
                dp[i] = 1;
                counter[i] = 1;
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                            counter[i] = counter[j];
                        }
                        else if (dp[j] + 1 == dp[i])
                            counter[i] += counter[j];
                    }
                }
                if (dp[i] > max) max = dp[i];
            }
            for (int i = 0; i < len; i++)
            {
                if (dp[i] == max) count += counter[i];
            }
            return count;
        }
    }
}
