using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 03.05. 栈排序
/// https://leetcode-cn.com/problems/sort-of-stacks-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class SortedStack
    {
        private List<int> data;
        public SortedStack()
        {
            data = new List<int>();
        }

        public void Push(int val)
        {
            if (data.Count == 0)
                data.Add(val);
            else
            {
                int index = -1;
                //Console.WriteLine(index);
                for (int i = data.Count - 1; i >= 0; i--)
                {
                    if (data[i] < val)
                    {
                        index = i;
                        break;
                    }
                }
                data.Insert(index + 1, val);
                //Console.WriteLine(string.Join(",",data.ToArray()));
            }
        }

        public void Pop()
        {
            if (data.Count == 0) return;
            data.RemoveAt(0);
        }

        public int Peek()
        {
            return data.Count == 0 ? -1 : data[0];
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }
    }
}
