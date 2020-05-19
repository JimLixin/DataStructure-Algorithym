using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 680. 验证回文字符串 Ⅱ
/// https://leetcode-cn.com/problems/valid-palindrome-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00680_valid_palindrome_ii
    {
        public bool ValidPalindrome(string s)
        {
            char[] array = s.ToCharArray();
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                if (array[left] == array[right])
                {
                    left++;
                    right--;
                }
                else
                    return valid(array, left + 1, right) || valid(array, left, right - 1);
            }
            return true;
        }

        public bool valid(char[] data, int start, int end)
        {
            return start == end ? true : (data[start] == data[end]) && (end - start == 1 ? true : valid(data, start + 1, end - 1));
        }
    }
}
