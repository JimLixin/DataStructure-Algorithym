using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题59 - II. 队列的最大值
    /// https://leetcode-cn.com/problems/dui-lie-de-zui-da-zhi-lcof/
    /// </summary>
    public class MaxQueue
    {
        Queue<int> q;
        List<int> data;
        int max, len;
        bool sorted;
        public MaxQueue()
        {
            q = new Queue<int>();
            data = new List<int>();
            max = int.MinValue;
        }

        public int Max_value()
        {
            if (len == 0) return -1;
            if (!sorted)
                data.Sort();
            return data[len - 1];
        }

        public void Push_back(int value)
        {
            q.Enqueue(value);
            data.Add(value);
            len++;
            if (value > max)
                max = value;
        }

        public int Pop_front()
        {
            if (len == 0) return -1;
            int num = q.Dequeue();
            data.Remove(num);
            len--;
            return num;
        }
    }
}
