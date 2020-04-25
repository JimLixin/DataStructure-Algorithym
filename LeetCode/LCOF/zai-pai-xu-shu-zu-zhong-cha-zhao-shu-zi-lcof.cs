using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题53 - I. 在排序数组中查找数字 I
    /// https://leetcode-cn.com/problems/zai-pai-xu-shu-zu-zhong-cha-zhao-shu-zi-lcof/
    /// </summary>
    public class zai_pai_xu_shu_zu_zhong_cha_zhao_shu_zi_lcof
    {
        public int Search(int[] nums, int target)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += (nums[i] == target ? 1 : 0);
            }
            return count;
        }
    }
}
