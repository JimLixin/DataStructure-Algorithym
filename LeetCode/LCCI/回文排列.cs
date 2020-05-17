using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.04. 回文排列
/// https://leetcode-cn.com/problems/palindrome-permutation-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 回文排列
    {
        public bool CanPermutePalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic.Add(c, 1);
            }
            int count = 0;
            foreach (int n in dic.Values)
            {
                if ((n & 1) > 0)
                    count++;
            }
            return count <= 1;
        }
    }
}
