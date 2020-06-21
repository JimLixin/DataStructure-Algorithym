using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 14. 最长公共前缀
    /// https://leetcode-cn.com/problems/longest-common-prefix/
    /// </summary>
    public static class LongestCommonPrefix
    {
        public static string Answer(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];
            string commonPrefix = strs[0];
            bool indicator = false;

            while (!indicator)
            {
                indicator = !strs.Any(s => !s.StartsWith(commonPrefix));
                commonPrefix = indicator ? commonPrefix : commonPrefix.Substring(0, commonPrefix.Length - 1);
            }
            return commonPrefix;
        }
    }
}
