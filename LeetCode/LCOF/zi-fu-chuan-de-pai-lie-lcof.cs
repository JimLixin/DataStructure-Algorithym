using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题38. 字符串的排列
    /// https://leetcode-cn.com/problems/zi-fu-chuan-de-pai-lie-lcof/
    /// </summary>
    public class zi_fu_chuan_de_pai_lie_lcof
    {
        int step, len;
        bool[] vis;
        char[] data;
        HashSet<string> result;
        public string[] Permutation(string s)
        {
            if (string.IsNullOrEmpty(s))
                return new string[] { "" };
            result = new HashSet<string>();
            len = s.Length;
            vis = new bool[len + 1];
            data = new char[len];
            dfs(s, 0);
            return result.ToArray();
        }

        public void dfs(string s, int step)
        {
            if (step >= len)
            {
                string str = new String(data);
                if (!result.Contains(str))
                    result.Add(str);
                return;
            }
            for (int i = 0; i < len; i++)
            {
                if (!vis[i])
                {
                    vis[i] = true;
                    data[step] = s[i];
                    dfs(s, step + 1);
                    data[step] = ' ';
                    vis[i] = false;
                }
            }
        }
    }
}
