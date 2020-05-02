using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 844. 比较含退格的字符串
    /// https://leetcode-cn.com/problems/backspace-string-compare/
    /// </summary>
    public class backspace_string_compare
    {
        public bool BackspaceCompare(string S, string T)
        {
            return buildStr(S) == buildStr(T);
        }

        public string buildStr(string input)
        {
            int backCount = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '#')
                    backCount++;
                else
                {
                    if (backCount > 0)
                        backCount--;
                    else
                        sb.Insert(0, input[i]);
                }
            }
            return sb.ToString();
        }
    }
}
