using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 209. 长度最小的子数组
/// https://leetcode-cn.com/problems/minimum-size-subarray-sum/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00209_长度最小的子数组
    {
        /// <summary>
        /// 前缀和
        /// 执行用时 :2808 ms, 在所有 C# 提交中击败了5.05%的用户
        /// 内存消耗 :25.8 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="s"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums == null || nums.Length == 0 || s <= 0)
                return 0;
            int len = nums.Length, min = int.MaxValue;
            int[] sums = new int[len];
            for (int n = 0; n < len; n++)
            {
                sums[n] = (n == 0 ? 0 : sums[n - 1]) + nums[n];
                if (nums[n] >= s) return 1;
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if ((i == 0 ? sums[j] : sums[j] - sums[i - 1]) >= s) min = Math.Min(min, j - i + 1);
                }
            }
            return min == int.MaxValue ? 0 : min;
        }
        /// <summary>
        /// 滑动窗口 + 双指针
        /// 执行用时 :112 ms, 在所有 C# 提交中击败了91.92%的用户
        /// 内存消耗 :25.6 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="s"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinSubArrayLenV2(int s, int[] nums)
        {
            if (nums == null || nums.Length == 0 || s <= 0)
                return 0;
            int len = nums.Length, left = 0, right = 0, sum = nums[0], min = int.MaxValue;
            while (right < len)
            {
                if (sum < s)
                {
                    right++;
                    if (right >= len) break;
                    sum += nums[right];
                }
                else
                {
                    min = Math.Min(min, right - left + 1);
                    sum -= nums[left++];
                }
            }
            return min == int.MaxValue ? 0 : min;
        }
    }
}
