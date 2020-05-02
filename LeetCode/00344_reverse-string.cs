using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 344. 反转字符串
    /// https://leetcode-cn.com/problems/reverse-string/
    /// </summary>
    public class reverse_string
    {
        public void ReverseString(char[] s)
        {
            if (s == null || s.Length == 0) return;
            int left = 0, right = s.Length - 1;
            char tmp;
            while (left < right)
            {
                tmp = s[right];
                s[right] = s[left];
                s[left] = tmp;
                left++;
                right--;
            }
        }
    }
}
