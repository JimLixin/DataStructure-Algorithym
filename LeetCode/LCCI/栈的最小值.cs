using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 03.02. 栈的最小值
/// https://leetcode-cn.com/problems/min-stack-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class MinStack
    {
        private Stack<int> s;
        private List<int> l;
        /** initialize your data structure here. */
        public MinStack()
        {
            s = new Stack<int>();
            l = new List<int>();
        }

        public void Push(int x)
        {
            s.Push(x);
            if (l.Count == 0)
                l.Add(x);
            else
            {
                int index = l.Count - 1;
                while (index >= 0 && l[index] > x) index--;
                l.Insert(index + 1, x);
            }
        }

        public void Pop()
        {
            l.Remove(s.Pop());
        }

        public int Top()
        {
            return s.Peek();
        }

        public int GetMin()
        {
            return l[0];
        }
    }
}
