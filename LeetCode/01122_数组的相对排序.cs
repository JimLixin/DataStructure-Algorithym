using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1122. 数组的相对排序
/// https://leetcode-cn.com/problems/relative-sort-array/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01122_数组的相对排序
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0) return arr2;
            int pos = 0;
            int[] data = new int[1001];
            for (int n = 0; n < arr1.Length; n++) data[arr1[n]]++;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (data[arr2[i]] == 0) continue;
                for (int k = 0; k < data[arr2[i]]; k++) arr1[pos++] = arr2[i];
                data[arr2[i]] = 0;
            }
            for (int i = 0; i < 1001; i++)
            {
                if (data[i] == 0) continue;
                for (int k = 0; k < data[i]; k++) arr1[pos++] = i;
                data[i] = 0;
            }
            return arr1;
        }
    }
}
