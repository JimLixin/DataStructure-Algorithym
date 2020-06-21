using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 90. 子集 II
/// https://leetcode-cn.com/problems/subsets-ii/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class subsets_ii
    {
        Dictionary<string, IList<int>> result;
        IList<int> data;
        int len;
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            result = new Dictionary<string, IList<int>>();
            result.Add("", new List<int>());
            if (nums == null || nums.Length == 0)
                result.Values.ToList();
            len = nums.Length;
            data = new List<int>();
            Array.Sort(nums);
            dfs(nums, 0, 0);
            return result.Values.ToList();
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
                string key = string.Join("", data);
                if (!result.ContainsKey(key))
                {
                    result.Add(key, new List<int>(data.ToArray()));
                    dfs(nums, step + 1, i + 1);
                }
                data.Remove(nums[i]);
            }
        }
    }
}
