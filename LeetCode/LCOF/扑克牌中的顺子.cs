using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题61. 扑克牌中的顺子
/// https://leetcode-cn.com/problems/bu-ke-pai-zhong-de-shun-zi-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 扑克牌中的顺子
    {
        public bool IsStraight(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;
            Array.Sort(nums);
            int zeroCnt = 0, start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    zeroCnt++;
            }
            start = zeroCnt;
            for (int i = start + 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) return false;
                zeroCnt -= nums[i] - nums[i - 1] - 1;
                if (zeroCnt < 0) return false;
            }
            return true;
        }

        /// <summary>
        /// 优化过的版本
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool IsStraightV2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;
            Array.Sort(nums);
            int zeroCnt = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCnt++;
                    continue;
                }
                if (nums[i] == nums[i + 1]) return false;
                zeroCnt -= nums[i + 1] - nums[i] - 1;
                if (zeroCnt < 0) return false;
            }
            return true;
        }
    }
}
