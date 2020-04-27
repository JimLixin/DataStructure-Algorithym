using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题56 - I. 数组中数字出现的次数
    /// https://leetcode-cn.com/problems/shu-zu-zhong-shu-zi-chu-xian-de-ci-shu-lcof/
    /// </summary>
    public class TestSolution
    {
        public int[] SingleNumbers(int[] nums)
        {
            int xor = Enumerable.Aggregate(nums, (a, b) => a^b);
            int factor = 1, x = 0, y = 0;
            while ((factor & xor) == 0) factor <<= 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & factor) == 0)
                    x ^= nums[i];
                else
                    y ^= nums[i];
            }
            return new int[] { x, y };
        }
    }
}
