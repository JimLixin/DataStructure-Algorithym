using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/valid-anagram/
    /// </summary>
    public class valid_anagram
    {
        public bool IsAnagram(string s, string t)
        {
            char[] sArr = s.ToCharArray();
            Array.Sort(sArr);
            char[] tArr = t.ToCharArray();
            Array.Sort(tArr);
            return new String(sArr) == new String(tArr);
        }

        public bool IsAnagramV2(string s, string t)
        {
            return false;
        }
    }
}
