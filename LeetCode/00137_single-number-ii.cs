using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 137. 只出现一次的数字 II
/// https://leetcode-cn.com/problems/single-number-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00137_single_number_ii
    {
        public int SingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int[] data = new int[32];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    data[j] += nums[i] & 1;
                    nums[i] >>= 1;
                }
            }
            int result = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                result <<= 1;
                result += data[i] % 3;
            }
            return result;
        }
    }
}
