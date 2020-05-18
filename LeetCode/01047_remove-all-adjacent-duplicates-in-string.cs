using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1047. 删除字符串中的所有相邻重复项
/// https://leetcode-cn.com/problems/remove-all-adjacent-duplicates-in-string/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01047_remove_all_adjacent_duplicates_in_string
    {
        /// <summary>
        /// 原始版本
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string S)
        {
            int index = 1;
            while (index < S.Length)
            {
                if (S[index] == S[index - 1])
                {
                    S = S.Remove(index - 1, 2);
                    index = 1;
                    continue;
                }
                index++;
            }
            return S;
        }

        /// <summary>
        /// 使用栈实现
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public string RemoveDuplicatesV2(string S)
        {
            Stack<char> s = new Stack<char>();
            foreach (char c in S)
            {
                if (s.Count == 0 || s.Peek() != c)
                    s.Push(c);
                else
                    s.Pop();
            }
            return new String(s.ToArray().Reverse().ToArray());
        }
    }
}
