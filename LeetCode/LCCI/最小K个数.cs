using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 面试题 17.14. 最小K个数
/// https://leetcode-cn.com/problems/smallest-k-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 快速选择 QuickSelect
    /// </summary>
    public class 最小K个数
    {
        int[] _arr = null;
        List<int> result = null;
        public int[] SmallestK(int[] arr, int k)
        {
            if (k == 0) return new int[0];
            _arr = arr;
            result = new List<int>();
            QuickSelect(0, _arr.Length - 1, k);
            return result.ToArray();
        }

        public void QuickSelect(int left, int right, int k)
        {
            int pivot = (new Random()).Next(left, right), i = left, j = left;
            Swap(pivot, right);
            while (j < right)
            {
                if (_arr[j] >= _arr[right]) Swap(i++, j);
                j++;
            }
            Swap(i, right);
            if (i + k - 1 == right)
                for (int n = i; n <= right; n++) result.Add(_arr[n]);
            else if (i + k - 1 > right)
            {
                for (int n = i; n <= right; n++) result.Add(_arr[n]);
                QuickSelect(left, i - 1, k - (right - i + 1));
            }
            else
                QuickSelect(i + 1, right, k);
        }

        public void Swap(int a, int b)
        {
            int tmp = _arr[a];
            _arr[a] = _arr[b];
            _arr[b] = tmp;
        }
    }
}
