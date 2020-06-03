using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 93. 复原IP地址
/// https://leetcode-cn.com/problems/restore-ip-addresses/
/// </summary>
namespace Algorithym.LeetCode.递归_回溯
{
    public class _00093_复原IP地址
    {
        List<string> result;
        List<int> data;
        bool[] vis;
        public IList<string> RestoreIpAddresses(string s)
        {
            result = new List<string>();
            data = new List<int>();
            vis = new bool[4];
            dfs(s, 0);
            return result;
        }

        public void dfs(string s, int step)
        {
            if (step == 4)
            {
                if (s.Length == 0)
                    result.Add(string.Join(".", data));
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                if (s.Length < i + 1) break;
                int val = Convert.ToInt32(s.Substring(0, i + 1));
                if (i > 0 && val < 10) break;
                if (val > 255) continue;
                if (!vis[step])
                {
                    vis[step] = true;
                    data.Add(val);
                    dfs(s.Substring(i + 1), step + 1);
                    data.RemoveAt(data.Count - 1);
                    vis[step] = false;
                }
            }
        }
    }
}
