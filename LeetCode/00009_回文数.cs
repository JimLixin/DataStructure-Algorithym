using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 9. 回文数
    /// https://leetcode-cn.com/problems/palindrome-number/
    /// </summary>
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x < 10)
                return true;

            string str = x.ToString();
            int i = 0, j = str.Length - 1;
            while (j > i + 1)
            {
                if (str[i] != str[j])
                    return false;

                i++;
                j--;
            }
            return i == j ? true : (str[i] == str[j]);
        }
    }
}
