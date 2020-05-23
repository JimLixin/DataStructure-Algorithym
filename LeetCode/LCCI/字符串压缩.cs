using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.06. 字符串压缩
/// https://leetcode-cn.com/problems/compress-string-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 字符串压缩
    {
        public string CompressString(string S)
        {
            if (string.IsNullOrEmpty(S)) return S;
            StringBuilder sb = new StringBuilder();
            int fast = 0, slow = 0;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] != S[i - 1])
                {
                    char c = S[slow];
                    sb.Append($"{c}{fast - slow + 1}");
                    fast++;
                    slow = fast;
                }
                else
                    fast++;
            }
            if (slow <= fast)
            {
                char c = S[slow];
                sb.Append($"{c}{fast - slow + 1}");
            }
            return sb.Length >= S.Length ? S : sb.ToString();
        }
    }
}
