using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 131. 分割回文串
/// https://leetcode-cn.com/problems/palindrome-partitioning/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 回溯(无优化)
    /// 执行用时 :332 ms, 在所有 C# 提交中击败了57.58%的用户
    /// 内存消耗 :34 MB, 在所有 C# 提交中击败了100.00%的用户
    /// </summary>
    public class _00131_分割回文串
    {
        IList<IList<string>> result;
        List<string> data;
        public IList<IList<string>> Partition(string s)
        {
            result = new List<IList<string>>();
            data = new List<string>();
            dfs(s);
            return result;
        }

        private void dfs(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                result.Add(new List<string>(data.ToArray()));
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                string left = s.Substring(0, i + 1);
                if (!isPalindrome(left)) continue;
                data.Add(left);
                dfs(s.Substring(i + 1));
                data.RemoveAt(data.Count - 1);
            }
        }

        private bool isPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            int left = 0, right = s.Length - 1;
            while (left <= right)
            {
                if (s[left++] != s[right--]) return false;
            }
            return true;
        }
    }

    /// <summary>
    /// 回溯 + 动态规划(保存不同位置是否为回文串的结果)
    /// </summary>
    public class _00131_分割回文串V2
    {
        IList<IList<string>> result;
        List<string> data;
        bool[,] dp;
        public IList<IList<string>> Partition(string s)
        {
            result = new List<IList<string>>();
            data = new List<string>();
            dp = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j)
                        dp[i, j] = true;
                    else if (i - j == 1)
                        dp[i, j] = s[i] == s[j];
                    else
                        dp[i, j] = s[i] == s[j] && dp[i - 1, j + 1];
                }
            }

            dfs(s, 0);
            return result;
        }

        private void dfs(string s, int index)
        {
            if (index == s.Length)
            {
                result.Add(new List<string>(data.ToArray()));
                return;
            }

            for (int i = index; i < s.Length; i++)
            {
                if (!dp[i, index]) continue;
                data.Add(s.Substring(index, i - index + 1));
                dfs(s, i + 1);
                data.RemoveAt(data.Count - 1);
            }
        }
    }
}
