using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 76. 最小覆盖子串
/// https://leetcode-cn.com/problems/minimum-window-substring/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00076_minimum_window_substring
    {
        Dictionary<char, int> dicS;
        Dictionary<char, int> dicT;
        public string MinWindow(string s, string t)
        {
            int left = -1, right = -1, min = s.Length;
            string result = "";
            dicS = new Dictionary<char, int>();
            dicT = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (dicT.ContainsKey(c))
                    dicT[c]++;
                else
                    dicT.Add(c, 1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                while (cover())
                {
                    if (left >= 0 && right - left < min)
                    {
                        min = right - left;
                        result = s.Substring(left, right - left + 1);
                    }
                    if (left >= 0 && dicS.ContainsKey(s[left]))
                        dicS[s[left]]--;
                    left++;
                }
                if (dicT.ContainsKey(s[i]))
                {
                    if (dicS.ContainsKey(s[i]))
                        dicS[s[i]]++;
                    else
                        dicS.Add(s[i], 1);
                }
                right++;
                //Console.WriteLine($"i:{i},left:{left}, right:{right}");
            }
            while (cover())
            {
                if (left >= 0 && right - left < min)
                {
                    min = right - left;
                    result = s.Substring(left, right - left + 1);
                }
                if (left >= 0 && dicS.ContainsKey(s[left]))
                    dicS[s[left]]--;
                left++;
            }
            return result;
        }

        public bool cover()
        {
            foreach (char c in dicT.Keys)
            {
                if (!dicS.ContainsKey(c) || dicS[c] < dicT[c])
                    return false;
            }
            return true;
        }
    }
}
