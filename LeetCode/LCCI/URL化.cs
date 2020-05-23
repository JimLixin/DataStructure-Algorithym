using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.03. URL化
/// https://leetcode-cn.com/problems/string-to-url-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class URL化
    {
        public string ReplaceSpaces(string S, int length)
        {
            char[] data = new char[S.Length];
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (S[i] == ' ')
                {
                    data[index++] = '%';
                    data[index++] = '2';
                    data[index++] = '0';
                }
                else
                    data[index++] = S[i];
            }
            return new String(data, 0, index);
        }
    }
}
