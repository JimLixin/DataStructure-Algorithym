using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 151. 翻转字符串里的单词
/// https://leetcode-cn.com/problems/reverse-words-in-a-string/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00151_翻转字符串里的单词
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;
            StringBuilder result = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (sb.Length > 0)
                    {
                        result.Append(sb.ToString());
                        result.Append(' ');
                        sb.Clear();
                    }
                    else continue;
                }
                else
                    sb.Insert(0, s[i]);
            }
            if (sb.Length > 0)
            {
                result.Append(sb.ToString());
                return result.ToString();
            }
            else
                return result.Remove(result.Length - 1, 1).ToString();

        }
    }
}
