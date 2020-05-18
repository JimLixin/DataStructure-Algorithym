using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 232. 用栈实现队列
/// https://leetcode-cn.com/problems/implement-queue-using-stacks/
/// </summary>
namespace Algorithym.LeetCode
{
    public class MyQueue
    {
        private Stack<int> s1;
        private Stack<int> s2;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            s1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (s2.Count > 0)
                return s2.Pop();
            else
            {
                Dump();
                return s2.Pop();
            }
        }

        /** Get the front element. */
        public int Peek()
        {
            if (s2.Count > 0)
                return s2.Peek();
            else
            {
                Dump();
                return s2.Peek();
            }
        }

        private void Dump()
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s1.Count == 0 && s2.Count == 0;
        }
    }
}
