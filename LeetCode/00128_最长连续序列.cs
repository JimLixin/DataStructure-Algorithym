using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 128. 最长连续序列
/// https://leetcode-cn.com/problems/longest-consecutive-sequence/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00128_最长连续序列
    {
        /// <summary>
        /// 预先排序
        /// 时间： O(NlogN)
        /// 空间： O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;
            Array.Sort(nums);
            int left = 0, right = 1, max = 0, dup = 0;
            while (right < nums.Length)
            {
                if (nums[right] == nums[right - 1])
                {
                    dup++;
                    right++;
                    continue;
                }
                if (nums[right] - nums[right - 1] != 1)
                {
                    max = Math.Max(max, right - left - dup);
                    left = right;
                    dup = 0;
                }
                right++;
            }
            max = Math.Max(max, right - left - dup);
            return max == 0 ? nums.Length - dup : max;
        }

        /// <summary>
        /// 并查集级？？？ Need to understanding!!!
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int LongestConsecutiveV2(int[] arr)
        {
            var dic = new Dictionary<int, int>();
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int x = arr[i];
                if (!dic.ContainsKey(x))
                {
                    dic[x] = dic.ContainsKey(x + 1) ? ++dic[x + dic[x + 1]] : 1;
                    res = Math.Max(res, dic.ContainsKey(x - 1) ?
                     dic[x - dic[x - 1]] = dic[dic[x] + x - 1] += dic[x - 1] : dic[x]);
                }
            }
            return res;
        }
    }
}
