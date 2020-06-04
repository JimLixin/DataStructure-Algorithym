using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 238. 除自身以外数组的乘积
/// https://leetcode-cn.com/problems/product-of-array-except-self/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00238_除自身以外数组的乘积
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length, data = 1;
            int[] result = new int[len];
            result[0] = nums[0];
            for (int i = 1; i < len; i++)
            {
                result[i] = result[i - 1] * nums[i];
            }
            for (int i = len - 1; i > 0; i--)
            {
                result[i] = result[i - 1] * data;
                data *= nums[i];
            }
            result[0] = data;
            return result;
        }
    }
}
