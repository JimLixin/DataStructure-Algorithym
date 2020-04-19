using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/
    /// </summary>
    public class single_number
    {
        public int SingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }
            return xor;
        }
    }
}
