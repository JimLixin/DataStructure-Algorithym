using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    public class subsets
    {
        IList<IList<int>> result;
        IList<int> data;
        int len;
        public IList<IList<int>> Subsets(int[] nums)
        {
            result = new List<IList<int>>();
            result.Add(new List<int>());
            if (nums == null || nums.Length == 0)
                return result;
            len = nums.Length;
            data = new List<int>();
            dfs(nums, 0, 0);
            return result;
        }

        public void dfs(int[] nums, int step, int cur)
        {
            if (step >= len)
            {
                return;
            }
            for (int i = cur; i < len; i++)
            {
                data.Add(nums[i]);
                result.Add(new List<int>(data.ToArray()));
                dfs(nums, step + 1, i + 1);
                data.Remove(nums[i]);
            }
        }
    }
}
