using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1027. 最长等差数列
/// https://leetcode-cn.com/problems/longest-arithmetic-sequence/
/// </summary>
namespace Algorithym.LeetCode.动态规划
{
    public class _01027_最长等差数列
    {
        public int LongestArithSeqLength(int[] A)
        {
            int len = A.Length, max = 2;
            int[,] dp = new int[len, len];
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < len; i++)
            {
                if (!dic.ContainsKey(A[i]))
                    dic[A[i]] = new List<int>();
                dic[A[i]].Add(i);
            }
            for (int i = 0; i < len; i++)
            {
                dp[i, i] = 1;
                for (int j = i + 1; j < len; j++)
                {
                    dp[i, j] = 2;
                    int target = A[i] * 2 - A[j];
                    if (dic.ContainsKey(target))
                    {
                        foreach (int ind in dic[target])
                        {
                            if (ind < i)
                                dp[i, j] = dp[ind, i] + 1;
                        }
                    }
                    if (dp[i, j] > max) max = dp[i, j];
                }
            }
            return max;
        }
    }
}
