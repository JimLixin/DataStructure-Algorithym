using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 3. 无重复字符的最长子串
    /// https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public static class LengthOfLongestSubstring
    {
        static int Answer(string s)
        {
            int[] strArray = new int[s.Length];
            int counter = 0, tmpCounter = 0, start = 0;
            bool match = false;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i - 1; j >= start; j--)
                {
                    if (strArray[j] == (int)s[i])
                    {
                        match = true;
                        if (tmpCounter > counter)
                        {
                            counter = tmpCounter;
                        }
                        tmpCounter = (i - j);
                        start = j + 1;
                        break;
                    }
                }
                strArray[i] = (int)s[i];
                if (!match)
                {
                    tmpCounter++;
                }
                match = false;
            }

            return tmpCounter > counter ? tmpCounter : counter;
        }

        static int AnswerV2(string s)
        {
            int max = 0;
            List<char> list = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                {
                    max = Math.Max(max, list.Count);
                    list.RemoveRange(0, list.IndexOf(s[i]) + 1);
                }
                list.Add(s[i]);
            }
            return Math.Max(max, list.Count);
        }
    }
}
