using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 47. 全排列 II
/// https://leetcode-cn.com/problems/permutations-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class permutations_ii
    {
        private Dictionary<string, IList<int>> result;
        private bool[] vis;
        private int len;
        private int[] data;
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            len = nums.Length;
            result = new Dictionary<string, IList<int>>();
            vis = new bool[len];
            data = new int[len];
            dfs(0, nums);
            return result.Values.ToList();
        }

        private void dfs(int step, int[] nums)
        {
            if (step >= len)
            {
                string key = string.Join("", data);
                if (!result.ContainsKey(key))
                    result.Add(key, new List<int>(data));
                return;
            }
            for (int i = 0; i < len; i++)
            {
                if (!vis[i])
                {
                    vis[i] = true;
                    data[step] = nums[i];
                    dfs(step + 1, nums);
                    vis[i] = false;
                }
            }
        }
    }
}
