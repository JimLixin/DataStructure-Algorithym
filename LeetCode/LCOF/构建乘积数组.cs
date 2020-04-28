using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题66. 构建乘积数组
    /// https://leetcode-cn.com/problems/gou-jian-cheng-ji-shu-zu-lcof/
    /// </summary>
    public class 构建乘积数组
    {
        public int[] ConstructArr(int[] a)
        {
            if (a == null || a.Length == 0)
                return new int[0];
            int len = a.Length;
            int[] data = new int[len];
            int tmp = 1;
            for (int i = 0; i < len; i++)
            {
                data[i] = tmp;
                tmp *= a[i];
            }
            tmp = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                data[i] *= tmp;
                tmp *= a[i];
            }
            return data;
        }
    }
}
