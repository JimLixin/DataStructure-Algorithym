using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    public static class implement_strstr
    {
        public static int Answer(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            int nLen = needle.Length;
            int hLen = haystack.Length;
            if (hLen < nLen)
                return -1;
            int index = 0;
            bool matched = true;
            while (index <= hLen - nLen)
            {
                if (haystack[index] == needle[0] && haystack[index + nLen - 1] == needle[nLen - 1])
                {
                    matched = true;
                    for (int i = index; i < index + nLen; i++)
                    {
                        if (haystack[i] != needle[i - index])
                        {
                            matched = false;
                            break;
                        }
                    }
                    if (matched)
                        return index;
                }
                index++;
            }
            return -1;
        }
    }
}
