using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 709. 转换成小写字母
/// https://leetcode-cn.com/problems/to-lower-case/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00709_to_lower_case
    {
        /// <summary>
        /// 原始方案
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ToLowerCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            char[] data = str.ToCharArray();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 65 && data[i] <= 90)
                    data[i] = (char)(data[i] + 32);
            }
            return new String(data);
        }

        /// <summary>
        /// 利用StringBuilder,性能大幅提升
        /// 执行用时 :88 ms, 在所有 C# 提交中击败了95.56%的用户
        /// 内存消耗 :22.4 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ToLowerCaseV2(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] >= 65 && sb[i] <= 90)
                    sb[i] = (char)(sb[i] + 32);
            }
            return sb.ToString();
        }
    }
}
