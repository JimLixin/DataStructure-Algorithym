using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题56 - II. 数组中数字出现的次数 II
    /// https://leetcode-cn.com/problems/shu-zu-zhong-shu-zi-chu-xian-de-ci-shu-ii-lcof/
    /// </summary>
    public class 数组中数字出现的次数_II
    {
        public int SingleNumber(int[] nums)
        {
            int[] digits = new int[32];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    digits[j] += (nums[i] & 1);
                    nums[i] >>= 1;
                }
            }
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                res <<= 1;
                res |= digits[31 - i] % 3;
            }
            return res;
        }

        /// <summary>
        /// A better solution need to understanding!!!!
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberV2(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[j] & (1 << i)) > 0)
                        ++count;
                }
                if (count % 3 != 0)
                    res ^= 1 << i;
            }
            return res;
        }
    }
}
