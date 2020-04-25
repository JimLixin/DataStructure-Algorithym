using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题30. 包含min函数的栈
    /// https://leetcode-cn.com/problems/bao-han-minhan-shu-de-zhan-lcof/
    /// </summary>
    public class MinStack
    {
        private Stack<int> s;
        private List<int> data;
        private bool flag;
        /** initialize your data structure here. */
        public MinStack()
        {
            s = new Stack<int>();
            data = new List<int>();
        }

        public void Push(int x)
        {
            s.Push(x);
            data.Add(x);
            flag = true;
        }

        public void Pop()
        {
            data.Remove(s.Pop());
        }

        public int Top()
        {
            return s.Peek();
        }

        public int Min()
        {
            if (flag)
            {
                data.Sort();
                flag = false;
            }
            return data[0];
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.Min();
     */
}
