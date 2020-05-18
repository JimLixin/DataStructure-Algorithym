using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 03.04. 化栈为队
/// https://leetcode-cn.com/problems/implement-queue-using-stacks-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class MyQueue
    {
        private Stack<int> master;
        private Stack<int> copy;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            master = new Stack<int>();
            copy = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            master.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (copy.Count == 0)
                Dump();
            return copy.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (copy.Count == 0)
                Dump();
            return copy.Peek();
        }

        private void Dump()
        {
            while (master.Count > 0)
                copy.Push(master.Pop());
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return master.Count == 0 && copy.Count == 0;
        }
    }
}
