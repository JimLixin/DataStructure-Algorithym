using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 368. 最大整除子集
/// https://leetcode-cn.com/problems/largest-divisible-subset/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00368_最大整除子集
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            IList<int> result = new List<int>();
            if (nums == null || nums.Length == 0)
                return result;
            int len = nums.Length, max = 0, end = -1;
            Array.Sort(nums);
            int[] dp = new int[len], back = new int[len];
            for (int i = 0; i < len; i++)
            {
                dp[i] = 1;
                back[i] = -1;
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0 && dp[j] <= dp[i] && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        back[i] = j;
                    }
                }
                if (dp[i] > max)
                {
                    max = dp[i];
                    end = i;

                }
            }
            while (end != -1)
            {
                result.Add(nums[end]);
                end = back[end];
            }
            return result.Reverse().ToList();
        }
    }
}
