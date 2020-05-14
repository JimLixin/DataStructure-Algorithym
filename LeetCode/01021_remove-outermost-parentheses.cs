using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1021. 删除最外层的括号
/// https://leetcode-cn.com/problems/remove-outermost-parentheses/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01021_remove_outermost_parentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            StringBuilder output = new StringBuilder();
            Stack<char> s = new Stack<char>();
            int openCount = 0, closeCount = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                s.Push(S[i]);
                if (S[i] == '(') openCount++;
                else closeCount++;
                if (openCount > 0 && closeCount > 0 && openCount == closeCount)
                {
                    char[] tmp = new char[openCount + closeCount - 2];
                    int index = 0, idx = 0;
                    while (s.Count > 0)
                    {
                        char c = s.Pop();
                        if (index > 0 && index < openCount + closeCount - 1)
                            tmp[idx++] = c;
                        index++;
                    }
                    output.Insert(0, tmp);
                    openCount = 0;
                    closeCount = 0;
                }
            }
            return output.ToString();
        }
    }
}
