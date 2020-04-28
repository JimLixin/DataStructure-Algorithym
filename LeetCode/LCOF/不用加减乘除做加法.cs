using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题65. 不用加减乘除做加法
    /// https://leetcode-cn.com/problems/bu-yong-jia-jian-cheng-chu-zuo-jia-fa-lcof/
    /// </summary>
    public class 不用加减乘除做加法
    {
        public int Add(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a ^ b;
                b = (a & b) << 1;
                a = tmp;
            }
            return a;
        }
    }
}
