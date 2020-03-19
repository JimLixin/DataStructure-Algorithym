using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class LengthOfLongestSubstringHelper
    {
        static int LengthOfLongestSubstring(string s)
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
    }
}
