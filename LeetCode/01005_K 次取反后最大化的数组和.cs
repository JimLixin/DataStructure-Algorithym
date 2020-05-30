using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1005. K 次取反后最大化的数组和
/// https://leetcode-cn.com/problems/maximize-sum-of-array-after-k-negations/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01005_K_次取反后最大化的数组和
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            if (A == null || A.Length == 0)
                return 0;
            int sum = 0, minPos = 0;
            int[] data = new int[201];
            for (int n = 0; n < A.Length; n++) data[A[n] + 100]++;
            while (K > 0)
            {
                if (data[minPos] == 0)
                {
                    minPos++;
                    continue;
                }
                data[200 - minPos]++;
                data[minPos]--;
                if (minPos > 100) minPos = 200 - minPos;
                K--;
            }
            for (int n = 0; n < data.Length; n++)
            {
                if (data[n] == 0) continue;
                sum += data[n] * (n - 100);
            }
            return sum;
        }
    }
}
