using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class permutations
    {
        private IList<IList<int>> result;
        private bool[] vis;
        private int len;
        private int[] data;
        public IList<IList<int>> Permute(int[] nums)
        {
            len = nums.Length;
            result = new List<IList<int>>();
            vis = new bool[len];
            data = new int[len];
            dfs(0, nums);
            return result;
        }

        private void dfs(int step, int[] nums)
        {
            if (step >= len)
            {
                result.Add(new List<int>(data));
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
