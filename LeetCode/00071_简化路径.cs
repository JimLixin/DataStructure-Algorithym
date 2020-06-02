using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 71. 简化路径
/// https://leetcode-cn.com/problems/simplify-path/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00071_简化路径
    {
        Stack<string> s;
        StringBuilder sBuilder;
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrEmpty(path)) return "";
            s = new Stack<string>();
            sBuilder = new StringBuilder();
            foreach (char c in path)
            {
                if (c == '/')
                    check();
                else
                    sBuilder.Append(c);
            }
            check();
            return "/" + string.Join("/", s.ToArray().Reverse());
        }

        public void check()
        {
            if (sBuilder.Length != 0)
            {
                string cur = sBuilder.ToString();
                if (cur != ".")
                {
                    if (cur == "..")
                    {
                        if (s.Count > 0) s.Pop();
                    }
                    else
                        s.Push(cur);
                }
                sBuilder.Clear();
            }
        }
    }
}
