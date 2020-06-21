using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 60. 第k个排列
/// https://leetcode-cn.com/problems/permutation-sequence/
/// </summary>
namespace Algorithym.LeetCode
{

    public class permutation_sequence
    {
        private int count;
        private string result;
        private int[] data;
        private bool[] vis;
        public string GetPermutation(int n, int k)
        {
            count = 0;
            vis = new bool[n];
            data = new int[n];
            dfs(0, n, k);
            return result;
        }

        public void dfs(int step, int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                if (!string.IsNullOrEmpty(result))
                    break;
                if (step >= n)
                {
                    count++;
                    if (count == k)
                    {
                        //Console.WriteLine(string.Join("", data));
                        result = string.Join("", data);
                    }
                    return;
                }
                if (!vis[i])
                {
                    vis[i] = true;
                    data[step] = i + 1;
                    dfs(step + 1, n, k);
                    vis[i] = false;
                }
            }
        }
    }

    /// <summary>
    ///  Why ???
    /// </summary>
    public class permutation_sequenceV2
    {
        public string GetPermutation(int n, int k)
        {
            List<int> nums = new List<int>();
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                nums.Add(i);
                fact *= i;
            }
            return GetPermutation(nums, fact, k - 1);
        }

        private string GetPermutation(List<int> nums, int fact, int k)
        {
            int n = nums.Count();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                fact /= (n - i);
                int index = k / fact;
                sb.Append(nums[index]);
                nums.RemoveAt(index);
                k -= fact * (index);
            }
            return sb.ToString();
        }
    }
}
