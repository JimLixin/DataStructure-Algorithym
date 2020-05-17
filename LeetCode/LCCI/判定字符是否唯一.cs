using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.01. 判定字符是否唯一
/// https://leetcode-cn.com/problems/is-unique-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 判定字符是否唯一
    {
        public bool IsUnique(string astr)
        {
            char[] data = astr.ToCharArray();
            Array.Sort(data);
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] == data[i - 1])
                    return false;
            }
            return true;
        }
    }
}
