using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 40. 组合总和 II
/// https://leetcode-cn.com/problems/combination-sum-ii/
/// </summary>
namespace Algorithym.LeetCode
{

    public static class combination_sum_ii
    {
        private static Dictionary<string, IList<int>> result;
        private static List<int> data;
        private static bool[] vis;
        public static IList<IList<int>> Answer(int[] candidates, int target)
        {
            result = new Dictionary<string, IList<int>>();
            data = new List<int>();
            vis = new bool[candidates.Length];
            Array.Sort(candidates);
            dfs(0, 0, candidates, target);
            return result.Values.ToList();
        }

        public static void dfs(int step, int index, int[] candidates, int target)
        {
            if (data.Sum() == target)
            {
                string key = string.Join("", data);
                if (!result.ContainsKey(key))
                    result.Add(key, data.ToArray());
                return;
            }
            else if (data.Sum() > target)
                return;

            for (int i = index; i < candidates.Length; i++)
            {
                if (!vis[i])
                {
                    vis[i] = true;
                    data.Add(candidates[i]);
                    dfs(step + 1, i, candidates, target);
                    data.RemoveAt(step);
                    vis[i] = false;
                }
            }
        }
    }
}
