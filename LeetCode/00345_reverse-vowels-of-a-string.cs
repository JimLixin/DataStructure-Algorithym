using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 345. 反转字符串中的元音字母
    /// https://leetcode-cn.com/problems/reverse-vowels-of-a-string/
    /// </summary>
    public class reverse_vowels_of_a_string
    {
        public string ReverseVowels(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            HashSet<char> map = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            int left = 0, right = s.Length - 1;
            char[] str = s.ToCharArray();
            char tmp;
            bool flag1, flag2;
            while (left < right)
            {
                flag1 = map.Contains(str[left]);
                flag2 = map.Contains(str[right]);
                if (flag1 && flag2)
                {
                    tmp = str[right];
                    str[right] = str[left];
                    str[left] = tmp;
                    left++;
                    right--;
                }
                if (!flag1) left++;
                if (!flag2) right--;
            }
            return new String(str);
        }
    }
}
