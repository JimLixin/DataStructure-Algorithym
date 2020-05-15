using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.前缀和
{
    public class _00560_subarray_sum_equals_k
    {
        /// <summary>
        /// 前缀和 + 哈希表优化
        /// 执行用时 :136 ms, 在所有 C# 提交中击败了63.64%的用户
        /// 内存消耗 :33.2 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraySumV2(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                int key = sum - k;
                if (map.ContainsKey(key))
                    count += map[key];
                map[sum] = map.ContainsKey(sum) ? ++map[sum] : 1;
            }
            return count;
        }
    }
}
