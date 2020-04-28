using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题64. 求1+2+…+n
    /// https://leetcode-cn.com/problems/qiu-12n-lcof/
    /// 求 1+2+...+n ，要求不能使用乘除法、for、while、if、else、switch、case等关键字及条件判断语句（A?B:C）。
    /// </summary>
    public class 求1_2___n
    {
        int res;
        public int SumNums(int n)
        {
            bool flag = (n > 1) && (SumNums(n - 1) > 0);
            res += n;
            return res;
        }
    }
}
