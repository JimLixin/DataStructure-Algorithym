using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 169. 多数元素
/// https://leetcode-cn.com/problems/majority-element/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00169_多数元素
    {
        public int MajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            Array.Sort(nums);
            return nums[nums.Length >> 1];
        }
    }
}
