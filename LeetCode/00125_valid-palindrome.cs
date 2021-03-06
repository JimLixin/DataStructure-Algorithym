﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome/
    /// Recursive
    /// </summary>
    public class valid_palindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;
            char[] data = String.Concat(s.Where(char.IsLetterOrDigit)).ToLower().ToCharArray();
            if (data.Length == 0)
                return true;
            return valid(data, 0, data.Length - 1);
        }

        public bool valid(char[] data, int start, int end)
        {
            return start == end ? true : (data[start] == data[end]) && (end - start == 1 ? true : valid(data, start + 1, end - 1));
        }
    }

    /// <summary>
    /// Iterative
    /// </summary>
    public class valid_palindromeV2
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;
            char[] data = String.Concat(s.Where(char.IsLetterOrDigit)).ToLower().ToCharArray();
            if (data.Length == 0)
                return true;
            bool result = true;
            int start = 0, end = data.Length - 1;
            while (start <= end)
            {
                if (end - start < 2)
                {
                    result = result && (start == end ? true : (data[start] == data[end]));
                    break;
                }
                else
                {
                    result = result && (data[start] == data[end]);
                    if (!result)
                        break;
                    start++;
                    end--;
                }
            }
            return result;
        }
    }

    /// <summary>
    /// Extremely fast solution!!!
    /// </summary>
    public class valid_palindromeV3
    {
        public bool IsPalindrome(string s)
        {

            int i = 0;
            int j = s.Length - 1;
            s = s.ToUpper();
            while (i < j)
            {
                if (((s[i] < 'A') || (s[i] > 'Z')) && ((s[i] < '0') || (s[i] > '9')))
                {
                    i++;
                    continue;
                }
                if (((s[j] < 'A') || (s[j] > 'Z')) && ((s[j] < '0') || (s[j] > '9')))
                {
                    j--;
                    continue;
                }
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
