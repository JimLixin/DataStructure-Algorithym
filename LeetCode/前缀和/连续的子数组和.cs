using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 523. 连续的子数组和
/// https://leetcode-cn.com/problems/continuous-subarray-sum/
/// </summary>
namespace Algorithym.LeetCode.前缀和
{
    public class _00523_continuous_subarray_sum
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
                return false;
            int sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                int key = k == 0 ? sum : sum % k;
                if (map.ContainsKey(key))
                {
                    if (i - map[key] > 1)
                        return true;
                }
                else
                    map.Add(key, i);
            }
            return false;
        }
    }
}
