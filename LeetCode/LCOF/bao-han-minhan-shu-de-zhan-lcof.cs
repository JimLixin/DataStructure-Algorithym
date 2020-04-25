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

    /// <summary>
    /// A better solution need to undetstanding!!!!
    /// </summary>
    public class MinStackV2
    {

        private int size = 0;
        private int[] arrayIdx = new int[20000];
        private int[] data = new int[20000];

        /** initialize your data structure here. */
        public MinStackV2()
        {

        }

        public void Push(int x)
        {
            if (size == 0)
            {
                arrayIdx[0] = 0;
            }
            else
            {
                if (data[arrayIdx[size - 1]] > x)
                {
                    arrayIdx[size] = size;
                }
                else
                {
                    arrayIdx[size] = arrayIdx[size - 1];
                }
            }
            data[size++] = x;
        }

        public void Pop()
        {
            data[--size] = 0;
            arrayIdx[size] = 0;
        }

        public int Top()
        {
            return data[size - 1];
        }

        public int Min()
        {
            return data[arrayIdx[size - 1]];
        }
    }

}
