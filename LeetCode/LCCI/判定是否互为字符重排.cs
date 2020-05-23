using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.02. 判定是否互为字符重排
/// https://leetcode-cn.com/problems/check-permutation-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 判定是否互为字符重排
    {
        public bool CheckPermutation(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1)) return string.IsNullOrEmpty(s2);
            if (string.IsNullOrEmpty(s2)) return string.IsNullOrEmpty(s1);
            if (s1.Length != s2.Length) return false;
            bool result = true;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s1)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic.Add(c, 1);
            }
            foreach (char c in s2)
            {
                if (!dic.ContainsKey(c))
                {
                    result = false;
                    break;
                }
                dic[c]--;
            }
            return dic.Values.All(v => v == 0);
        }
    }
}
