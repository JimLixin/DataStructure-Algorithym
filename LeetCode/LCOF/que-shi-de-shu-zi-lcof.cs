using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题53 - II. 0～n-1中缺失的数字
    /// https://leetcode-cn.com/problems/que-shi-de-shu-zi-lcof/
    /// </summary>
    public class que_shi_de_shu_zi_lcof
    {
        public int MissingNumber(int[] nums)
        {
            int xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ (i + 1) ^ nums[i];
            }
            return xor;
        }
    }
}
