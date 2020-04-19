using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// </summary>
    public class missing_number
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
