using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题39. 数组中出现次数超过一半的数字
    /// https://leetcode-cn.com/problems/shu-zu-zhong-chu-xian-ci-shu-chao-guo-yi-ban-de-shu-zi-lcof/
    /// </summary>
    public class shu_zu_zhong_chu_xian_ci_shu_chao_guo_yi_ban_de_shu_zi_lcof
    {
        public int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }

        /// <summary>
        /// Best solution need to understanding!!!
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElementV2(int[] nums)
        {
            if (nums is null || nums.Length == 0) return 0;
            int t = nums[0];
            int count = 0;
            foreach (int n in nums)
            {
                if (count == 0) t = n;
                if (n == t) count++;
                else count--;
            }
            return t;
        }
    }
}
