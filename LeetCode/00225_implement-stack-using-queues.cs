using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 225. 用队列实现栈
/// https://leetcode-cn.com/problems/implement-stack-using-queues/
/// </summary>
namespace Algorithym.LeetCode
{
    public class MyStack
    {
        private Queue<int> q1;
        private Queue<int> q2;
        /** Initialize your data structure here. */
        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            if (q1.Count > 0)
                q1.Enqueue(x);
            else
                q2.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (q1.Count > 0)
            {
                while (q1.Count > 1)
                    q2.Enqueue(q1.Dequeue());
                return q1.Dequeue();
            }
            else
            {
                while (q2.Count > 1)
                    q1.Enqueue(q2.Dequeue());
                return q2.Dequeue();
            }
        }

        /** Get the top element. */
        public int Top()
        {
            if (q1.Count > 0)
                return getQueueLast(q1);
            else
                return getQueueLast(q2);
        }

        private int getQueueLast(Queue<int> q)
        {
            int cnt = q.Count, index = 0;
            foreach (int n in q)
            {
                index++;
                if (index == cnt)
                    return n;
            }
            return -1;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.Count == 0 && q2.Count == 0;
        }
    }
}
