using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 面试题 17.01. 不用加号的加法
    /// https://leetcode-cn.com/problems/add-without-plus-lcci/
    /// </summary>
    public class 不用加号的加法
    {
        public int Add(int a, int b)
        {
            int tmp;
            while (b != 0)
            {
                tmp = a ^ b;
                b = (a & b) << 1;
                a = tmp;
            }
            return a;
        }
    }
}
