using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 面试题 17.04. 消失的数字
/// https://leetcode-cn.com/problems/missing-number-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 消失的数字
    {
        public int MissingNumber(int[] nums)
        {
            int xor = 0;
            for (int i = 0; i < nums.Length; i++) xor ^= nums[i] ^ (i + 1);
            return xor;
        }
    }
}
