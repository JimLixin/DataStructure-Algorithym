using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题21. 调整数组顺序使奇数位于偶数前面
    /// https://leetcode-cn.com/problems/diao-zheng-shu-zu-shun-xu-shi-qi-shu-wei-yu-ou-shu-qian-mian-lcof/
    /// </summary>
    public class diao_zheng_shu_zu_shun_xu_shi_qi_shu_wei_yu_ou_shu_qian_mian_lcof
    {
        public int[] Exchange(int[] nums)
        {
            int len = nums.Length, left = 0, right = len - 1;
            int[] data = new int[len];
            for (int i = 0; i < len; i++)
            {
                if ((nums[i] & 1) > 0)
                {
                    data[left] = nums[i];
                    left++;
                }
                else
                {
                    data[right] = nums[i];
                    right--;
                }
            }
            return data;
        }

        /// <summary>
        /// In-place replacement
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ExchangeV2(int[] nums)
        {
            int i = 0, j = nums.Length - 1;
            while (i < j)
            {
                while (i < j && (nums[i] & 1) > 0) i++;
                while (i < j && (nums[j] & 1) == 0) j--;
                if (i < j)
                {
                    nums[i] = nums[i] ^ nums[j];
                    nums[j] = nums[i] ^ nums[j];
                    nums[i] = nums[i] ^ nums[j];
                }
            }
            return nums;
        }
    }
}
