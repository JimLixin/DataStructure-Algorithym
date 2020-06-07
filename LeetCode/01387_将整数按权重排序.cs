using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1387. 将整数按权重排序
/// https://leetcode-cn.com/problems/sort-integers-by-the-power-value/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01387_将整数按权重排序
    {
        public int GetKth(int lo, int hi, int k)
        {
            SortedList<int, List<int>> data = new SortedList<int, List<int>>();
            for (int i = lo; i <= hi; i++)
            {
                int key = weight(i);
                if (!data.ContainsKey(key)) data[key] = new List<int>();
                data[key].Add(i);
            }
            foreach (int d in data.Keys)
            {
                foreach (int n in data[d])
                {
                    if (--k == 0) return n;
                }
            }

            return -1;
        }

        public int weight(int n)
        {
            int count = 0;
            while (n != 1)
            {
                count++;
                n = (n & 1) == 0 ? (n >> 1) : n * 3 + 1;
            }
            return count;
        }
    }
}
