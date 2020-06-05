using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 171. Excel表列序号
/// https://leetcode-cn.com/problems/excel-sheet-column-number/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00171_Excel表列序号
    {
        /// <summary>
        /// 从低位到高位
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int result = 0, factor = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += (s[i] - 64) * factor;
                factor *= 26;
            }
            return result;
        }

        /// <summary>
        /// 从高位到低位
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int TitleToNumberV2(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int result = 0;
            foreach (char c in s) result = result * 26 + c - 64;
            return result;
        }
    }
}
