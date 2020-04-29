using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题58 - I. 翻转单词顺序
    /// https://leetcode-cn.com/problems/fan-zhuan-dan-ci-shun-xu-lcof/
    /// </summary>
    public class 翻转单词顺序
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == ' ')
                {
                    if (sb2.Length > 0)
                    {
                        if (sb1.Length > 0)
                            sb2.Append(' ');
                        sb1.Insert(0, sb2.ToString());
                        sb2.Clear();
                    }
                }
                else
                    sb2.Append(s[i]);
                i++;
            }
            if (sb2.Length > 0)
            {
                if (sb1.Length > 0)
                    sb2.Append(' ');
                sb1.Insert(0, sb2.ToString());
            }
            return sb1.ToString();
        }
    }
}
