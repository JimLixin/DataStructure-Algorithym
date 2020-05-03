using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 303. 区域和检索 - 数组不可变
    /// https://leetcode-cn.com/problems/range-sum-query-immutable/
    /// </summary>
    public class NumArray
    {
        private int[] _nums;
        int len;
        int[,] dp;
        public NumArray(int[] nums)
        {
            _nums = nums;
            if (_nums == null || nums.Length == 0)
                return;
            len = nums.Length;
            dp = new int[len, len];
            for (int i = 0; i < len; i++) dp[i, i] = nums[i];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (i >= j) continue;
                    dp[i, j] = j - i == 1 ? dp[i, i] + dp[j, j] : dp[i, j - 1] + nums[j];
                }
            }
        }

        public int SumRange(int i, int j)
        {
            return len == 0 ? 0 : dp[i, j];
        }
    }

    public class NumArrayV2
    {
        int len;
        int[] sum;
        public NumArrayV2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            len = nums.Length;
            sum = new int[len];
            sum[0] = nums[0];
            for (int i = 1; i < len; i++)
            {
                sum[i] = sum[i - 1] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            if (len == 0) return 0;
            return i > 0 ? sum[j] - sum[i - 1] : sum[j];
        }
    }
}
