using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 08.08. 有重复字符串的排列组合
/// https://leetcode-cn.com/problems/permutation-ii-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 有重复字符串的排列组合
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
            char[] array = S.ToCharArray();
            Array.Sort(array);
            dfs(array, 0);
            return result.ToArray();
        }

        public void dfs(char[] s, int step)
        {
            if (step >= level)
            {
                result.Add(new String(data));
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!vis[i])
                {
                    if (i > 0 && s[i] == s[i - 1] && !vis[i - 1]) continue;
                    vis[i] = true;
                    data[step] = s[i];
                    dfs(s, step + 1);
                    vis[i] = false;
                }
            }
        }
    }
}
