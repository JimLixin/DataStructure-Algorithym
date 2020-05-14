using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 260. 只出现一次的数字 III
/// https://leetcode-cn.com/problems/single-number-iii/
/// </summary>
namespace Algorithym.LeetCode.位运算
{
    public class _00260_single_number_iii
    {
        public int[] SingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];
            int xorA = 0, xorB = 0, comparer = 1, xor = nums.Aggregate((a, b) => a ^ b);
            while (true)
            {
                if ((xor & 1) > 0) break;
                comparer <<= 1;
                xor >>= 1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & comparer) != 0)
                    xorA ^= nums[i];
                else
                    xorB ^= nums[i];
            }
            return new int[] { xorA, xorB };
        }

        /// <summary>
        /// Best solution from others, need to understanding!!!
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SingleNumberV2(int[] nums)
        {
            int bitmask = 0;
            foreach (var num in nums)
            {
                bitmask ^= num;
            }

            int diff = bitmask & (-bitmask);
            int x = 0;
            foreach (var num in nums)
            {
                if ((num & diff) != 0)
                {
                    x ^= num;
                }
            }

            return new[] { x, x ^ bitmask };
        }
    }
}
