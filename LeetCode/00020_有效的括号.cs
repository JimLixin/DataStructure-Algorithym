using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 20. 有效的括号
    /// https://leetcode-cn.com/problems/valid-parentheses/
    /// </summary>
    public static class valid_parentheses
    {
        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            int len = s.Length;
            if (len % 2 > 0)
                return false;
            Stack stack = new Stack();
            char current = ' ';
            foreach (char c in s)
            {
                if (current != ' ' && matched(current, c))
                {
                    stack.Pop();
                    current = stack.Count > 0 ? (char)stack.Peek() : ' ';
                }
                else
                {
                    stack.Push(c);
                    current = c;
                }
            }

            return stack.Count > 0 ? false : true;
        }

        private static bool matched(char a, char b)
        {
            return a == '{' && b == '}' || a == '(' && b == ')' || a == '[' && b == ']';
        }
    }
}
