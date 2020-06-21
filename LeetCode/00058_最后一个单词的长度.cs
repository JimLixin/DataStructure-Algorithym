using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 58. 最后一个单词的长度
/// https://leetcode-cn.com/problems/length-of-last-word/
/// </summary>
namespace Algorithym.LeetCode
{

    public class length_of_last_word
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            s = s.Trim();
            int len = s.Length, count = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                    return count;
                count++;
            }
            return count;
        }
    }
}
