using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 560. 和为K的子数组
/// https://leetcode-cn.com/problems/subarray-sum-equals-k/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00560_subarray_sum_equals_k
    {
        /// <summary>
        /// 原始版本
        /// 执行用时 :1872 ms, 在所有 C# 提交中击败了6.06%的用户
        /// 内存消耗 :28.6 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraySum(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int len = nums.Length, count = 0;
            int[] sums = new int[len + 1];
            sums[0] = 0;
            for (int i = 0; i < len; i++)
            {
                sums[i + 1] = sums[i] + nums[i];
            }
            //Console.WriteLine(string.Join(",", sums));
            for (int i = 0; i <= len; i++)
            {
                for (int j = i + 1; j <= len; j++)
                {
                    if (sums[j] - sums[i] == k)
                        count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 前缀和
        /// 执行用时 :136 ms, 在所有 C# 提交中击败了63.64%的用户
        /// 内存消耗 :33.2 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraySumV2(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                int key = sum - k;
                if (map.ContainsKey(key))
                    count += map[key];
                map[sum] = map.ContainsKey(sum) ? ++map[sum] : 1;
            }
            return count;
        }
    }
}
