using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1356. 根据数字二进制下 1 的数目排序
/// https://leetcode-cn.com/problems/sort-integers-by-the-number-of-1-bits/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01356_根据数字二进制下_1_的数目排序
    {
        public int[] SortByBits(int[] arr)
        {
            int pos = 0;
            List<int>[] data = new List<int>[32];
            for (int n = 0; n < arr.Length; n++)
            {
                int cnt = getDigits(arr[n]);
                if (data[cnt] == null) data[cnt] = new List<int>();
                data[cnt].Add(arr[n]);
            }
            for (int i = 0; i < 32; i++)
            {
                if (data[i] == null) continue;
                data[i].Sort();
                foreach (int num in data[i]) arr[pos++] = num;
            }
            return arr;
        }

        public int getDigits(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = (n & (n - 1));
                count++;
            }
            return count;
        }
    }
}
