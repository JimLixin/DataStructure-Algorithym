using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题58 - II. 左旋转字符串
    /// https://leetcode-cn.com/problems/zuo-xuan-zhuan-zi-fu-chuan-lcof/
    /// </summary>
    public class 左旋转字符串
    {
        public string ReverseLeftWords(string s, int n)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s.Substring(n, s.Length - n));
            sb.Append(s.Substring(0, n));
            return sb.ToString();
        }
    }
}
