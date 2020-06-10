using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 873. 最长的斐波那契子序列的长度
/// https://leetcode-cn.com/problems/length-of-longest-fibonacci-subsequence/
/// </summary>
namespace Algorithym.LeetCode.动态规划
{
    public class 最长的斐波那契子序列的长度
    {
        public class _00873_最长的斐波那契子序列的长度
        {
            public int LenLongestFibSubseq(int[] A)
            {
                int len = A.Length, max = 0;
                int[,] dp = new int[len, len];
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < len; i++)
                {
                    map[A[i]] = i;
                }
                for (int i = 0; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        dp[i, j] = 2;
                    }
                }
                for (int i = 0; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        int diff = A[j] - A[i];
                        if (map.ContainsKey(diff))
                        {
                            int pos = map[diff];
                            if (pos < i)
                            {
                                dp[i, j] = Math.Max(dp[i, j], dp[pos, i] + 1);
                            }
                            max = Math.Max(max, dp[i, j]);
                        }
                    }
                }
                return max;
            }
        }
    }
}
