using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 217. 存在重复元素
/// https://leetcode-cn.com/problems/contains-duplicate/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00217_contains_duplicate
    {
        /// <summary>
        /// 哈希表
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;
            HashSet<int> map = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.Contains(nums[i]))
                    map.Add(nums[i]);
                else
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicateV2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) return true;
            }
            return false;
        }
    }
}
