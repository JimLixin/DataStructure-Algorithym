using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1403. 非递增顺序的最小子序列
/// https://leetcode-cn.com/problems/minimum-subsequence-in-non-increasing-order/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01403_非递增顺序的最小子序列
    {
        /// <summary>
        /// 解法一： 预先排序原数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> MinSubsequence(int[] nums)
        {
            IList<int> result = new List<int>();
            if (nums == null || nums.Length == 0)
                return result;
            Array.Sort(nums);
            int len = nums.Length, total = 0;
            int[] sums = new int[len];
            sums[0] = nums[0];
            for (int i = 1; i < len; i++) sums[i] = sums[i - 1] + nums[i];
            for (int i = len - 1; i >= 0; i--)
            {
                total += nums[i];
                result.Add(nums[i]);
                if (i > 0 && total > sums[i - 1]) break;
            }
            return result;
        }

        /// <summary>
        /// 解法二：桶排序思想
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> MinSubsequenceV2(int[] nums)
        {
            IList<int> result = new List<int>();
            if (nums == null || nums.Length == 0)
                return result;
            int total = 0, sum = 0, i = 100;
            int[] data = new int[101];
            for (int n = 0; n < nums.Length; n++)
            {
                data[nums[n]]++;
                total += nums[n];
            }
            while (sum <= total - sum)
            {
                if (i < 0) break;
                if (data[i] == 0)
                {
                    i--;
                    continue;
                }
                sum += i;
                data[i]--;
                result.Add(i);
            }
            return result;
        }
    }
}
