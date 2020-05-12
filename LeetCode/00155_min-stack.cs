using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 155. 最小栈
/// https://leetcode-cn.com/problems/min-stack/
/// </summary>
namespace Algorithym.LeetCode
{
    public class MinStack
    {
        private List<int> data;
        private Stack<int> s;
        /** initialize your data structure here. */
        public MinStack()
        {
            data = new List<int>();
            s = new Stack<int>();
        }

        public void Push(int x)
        {
            s.Push(x);
            int index = -1;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] < x)
                {
                    index = i;
                    break;
                }
            }
            data.Insert(index + 1, x);

        }

        public void Pop()
        {
            int num = s.Pop();
            data.Remove(num);
        }

        public int Top()
        {
            return s.Peek();
        }

        public int GetMin()
        {
            return data[0];
        }
    }
}
