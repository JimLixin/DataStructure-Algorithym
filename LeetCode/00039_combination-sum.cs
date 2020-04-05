using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum/
    /// </summary>
    public static class combination_sum
    {
        private static IList<IList<int>> result;
        private static List<int> data;

        public static IList<IList<int>> Answer(int[] candidates, int target)
        {
            result = new List<IList<int>>();
            data = new List<int>();
            dfs(0, 0, candidates, target);
            return result;
        }

        public static void dfs(int step, int index, int[] candidates, int target)
        {
            if (data.Sum() == target)
            {
                result.Add(data.ToArray());
                return;
            }
            else if (data.Sum() > target)
                return;
            for (int i = index; i < candidates.Length; i++)
            {
                data.Add(candidates[i]);
                dfs(step + 1, i, candidates, target);
                data.RemoveAt(step);
            }
        }
    }
}
