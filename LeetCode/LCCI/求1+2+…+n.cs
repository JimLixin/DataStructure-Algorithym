using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 面试题64. 求1+2+…+n
/// https://leetcode-cn.com/problems/qiu-12n-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 求1_2___n
    {
        public int result;
        public int SumNums(int n)
        {
            helper(n);
            return result;
        }

        public bool helper(int n)
        {
            result += n;
            return n == 0 || helper(n - 1);
        }
    }
}
