using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            if (s.Length == 1)
                return getIntNumber(s[0]);

            char current = ' ';
            int charCount = 0, output = 0, special = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (current != ' ' && s[i] != current)
                {
                    special = getSpecialNumber(current, s[i]);
                    if (special > 0)
                    {
                        output += special;
                        current = ' ';
                        charCount = 0;
                    }
                    else
                    {
                        output += getIntNumber(current) * charCount;
                        current = s[i];
                        charCount = 1;
                    }
                    
                }
                else
                {
                    current = s[i];
                    charCount++;
                }
            }
            if (current != ' ')
            {
                output += getIntNumber(current) * charCount;
            }
            return output;
        }

        public static int getIntNumber(char roman)
        {
            switch (roman)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }
            return 0;
        }

        public static int getSpecialNumber(char prefix, char number)
        {
            int first = getIntNumber(prefix);
            int second = getIntNumber(number);
            int val = second - first;
            if (val/first == 4 || val / first == 9)
                return val;
            else
                return -1;
        }
    }
}
