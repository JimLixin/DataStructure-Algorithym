using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 152. 乘积最大子数组
    /// https://leetcode-cn.com/problems/maximum-product-subarray/
    /// </summary>
    public class _00152_乘积最大子数组
    {
        public int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int max = nums[0], min = max, result = max;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    max = max ^ min;
                    min = max ^ min;
                    max = max ^ min;
                }
                max = Math.Max(max * nums[i], nums[i]);
                min = Math.Min(min * nums[i], nums[i]);
                result = Math.Max(result, max);
            }
            return result;
        }
    }
}
