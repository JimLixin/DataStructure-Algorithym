using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 08.07. 无重复字符串的排列组合
/// https://leetcode-cn.com/problems/permutation-i-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 无重复字符串的排列组合
    {
        int level;
        char[] data;
        bool[] vis;
        IList<string> result;
        public string[] Permutation(string S)
        {
            result = new List<string>();
            if (string.IsNullOrEmpty(S)) return result.ToArray();
            level = S.Length;
            data = new char[level];
            vis = new bool[level];
            dfs(S, 0);
            return result.ToArray();
        }

        public void dfs(string S, int step)
        {
            if (step >= level)
            {
                result.Add(new String(data));
                return;
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (!vis[i])
                {
                    vis[i] = true;
                    data[step] = S[i];
                    dfs(S, step + 1);
                    vis[i] = false;
                }
            }
        }
    }
}
