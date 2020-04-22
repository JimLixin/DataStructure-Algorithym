using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// https://leetcode-cn.com/problems/shu-zu-zhong-zhong-fu-de-shu-zi-lcof/
    /// </summary>
    public class shu_zu_zhong_zhong_fu_de_shu_zi_lcof
    {
        /// <summary>
        /// Good at space complexity
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindRepeatNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((nums[i] ^ nums[i + 1]) == 0)
                    return nums[i];
            }
            return -1;
        }

        /// <summary>
        /// Good at time complexity
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindRepeatNumberV2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int len = nums.Length, cur;
            int[] data = new int[len];
            for (int i = 0; i < len; i++)
            {
                cur = nums[i];
                data[cur] = data[cur] > 0 ? (data[cur] + 1) : 1;
                if (data[cur] > 1)
                    return cur;
            }
            return -1;
        }
    }
}
