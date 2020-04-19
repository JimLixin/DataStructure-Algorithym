using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/set-mismatch/
    /// </summary>
    public class set_mismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int[] data = new int[nums.Length + 1];
            int dup = 0, xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i];
                if (data[cur] == 1)
                    dup = cur;
                data[cur]++;
                xor = xor ^ (i + 1) ^ cur;
            }
            return new int[] { dup, xor ^ dup };
        }
    }
}
