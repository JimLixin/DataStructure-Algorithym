using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1221. 分割平衡字符串
/// https://leetcode-cn.com/problems/split-a-string-in-balanced-strings/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01221_分割平衡字符串
    {
        public int BalancedStringSplit(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int cntL = 0, cntR = 0, count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    cntL++;
                else
                    cntR++;

                if (cntL == cntR)
                {
                    count++;
                    cntL = 0;
                    cntR = 0;
                }
            }
            return count;
        }
    }
}
