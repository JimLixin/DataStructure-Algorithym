using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题09. 用两个栈实现队列
    /// https://leetcode-cn.com/problems/yong-liang-ge-zhan-shi-xian-dui-lie-lcof/submissions/
    /// </summary>
    public class CQueue
    {
        private Stack<int> s1 = null;
        private Stack<int> s2 = null;
        private int count1;
        private int count2;
        public CQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
            count1 = 0;
            count2 = 0;
        }

        public void AppendTail(int value)
        {
            s1.Push(value);
            count1++;
        }

        public int DeleteHead()
        {
            if (count2 > 0)
            {
                count2--;
                return s2.Pop();
            }
            if (count1 == 0)
                return -1;

            int tmp = count1;
            for (int i = 0; i < tmp; i++)
            {
                count1--;
                count2++;
                s2.Push(s1.Pop());
            }
            count2--;
            return s2.Pop();
        }
    }

}
