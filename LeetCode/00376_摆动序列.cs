using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 376. 摆动序列
/// https://leetcode-cn.com/problems/wiggle-subsequence/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00376_摆动序列
    {
        /// <summary>
        /// 自己写出来的版本
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int WiggleMaxLength(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length < 2) return nums.Length;
            int? pre = null;
            int cur = 0, count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) continue;
                cur = nums[i] - nums[i - 1];
                if (pre == null)
                {
                    pre = cur;
                    if (pre != 0) count++;
                }
                else
                {
                    if (pre > 0 && cur < 0 || pre < 0 && cur > 0) count++;
                    pre = cur;
                }
            }
            return count;
        }

        /// <summary>
        /// 优化过的版本
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int WiggleMaxLengthV2(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length < 2) return nums.Length;
            int pre = nums[1] - nums[0], cur = 0, count = pre != 0 ? 2 : 1;
            for (int i = 2; i < nums.Length; i++)
            {
                cur = nums[i] - nums[i - 1];
                if (pre >= 0 && cur < 0 || pre <= 0 && cur > 0)
                {
                    count++;
                    pre = cur;
                }
            }
            return count;
        }
    }
}
