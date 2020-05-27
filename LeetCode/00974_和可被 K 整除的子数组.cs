using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 974. 和可被 K 整除的子数组
/// https://leetcode-cn.com/problems/subarray-sums-divisible-by-k/
/// </summary>
namespace Algorithym.LeetCode
{
   
    public class _00974_subarray_sums_divisible_by_k
    {
        /// <summary>
        /// 前缀和
        /// O(N^2)
        /// 超时
        /// </summary>
        public int SubarraysDivByK(int[] A, int K)
        {
            if (A == null || A.Length == 0) return 0;
            int count = 0, len = A.Length;
            int[] data = new int[len];
            for (int i = 0; i < len; i++)
            {
                data[i] = i == 0 ? A[0] : data[i - 1] + A[i];
                if (data[i] % K == 0)
                    count++;
            }
            for (int i = 1; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    if ((data[j] - data[i - 1]) % K == 0) count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 前缀和 + 哈希表 优化
        /// 执行用时 :196 ms, 在所有 C# 提交中击败了33.33%的用户
        /// 内存消耗 :35.6 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int SubarraysDivByKV2(int[] A, int K)
        {
            if (A == null || A.Length == 0) return 0;
            int count = 0, len = A.Length, sum = 0, k = Math.Abs(K);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, 1);
            for (int i = 0; i < len; i++)
            {
                sum += A[i];
                int key = sum % k;
                if (key < 0) key += k;
                if (dic.ContainsKey(key)) count += dic[key];
                dic[key] = dic.ContainsKey(key) ? ++dic[key] : 1;
            }
            return count;
        }
    }
}
