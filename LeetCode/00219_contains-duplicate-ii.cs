using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 219. 存在重复元素 II
/// https://leetcode-cn.com/problems/contains-duplicate-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00219_contains_duplicate_ii
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return false;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    if (Math.Abs(map[nums[i]] - i) <= k)
                        return true;
                    else
                        map[nums[i]] = i;
                }
                else
                    map.Add(nums[i], i);
            }
            return false;
        }
    }
}
