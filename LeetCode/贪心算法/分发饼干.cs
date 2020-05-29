using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 455. 分发饼干
/// https://leetcode-cn.com/problems/assign-cookies/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _00455_分发饼干
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            if (g == null || g.Length == 0 || s == null || s.Length == 0) return 0;
            Array.Sort(g);
            Array.Sort(s);
            int index = 0, count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (index >= g.Length) break;
                if (g[index] <= s[i])
                {
                    count++;
                    index++;
                }
            }
            return count;
        }
    }
}
