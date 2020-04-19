using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/combinations/
    /// </summary>
    public class combinations
    {
        IList<IList<int>> result;
        int[] data;
        bool[] vis;
        public IList<IList<int>> Combine(int n, int k)
        {
            result = new List<IList<int>>();
            data = new int[k];
            vis = new bool[k];
            dfs(n, k, 0, 0);
            return result;
        }

        public void dfs(int n, int k, int step, int cur)
        {
            if (step >= k)
            {
                result.Add(new List<int>(data));
                return;
            }
            for (int i = cur + 1; i <= n; i++)
            {
                if (!vis[step])
                {
                    vis[step] = true;
                    data[step] = i;
                    dfs(n, k, step + 1, i);
                    vis[step] = false;
                }
            }
        }
    }
}
