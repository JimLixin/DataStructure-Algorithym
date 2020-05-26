using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题16. 数值的整数次方
/// https://leetcode-cn.com/problems/shu-zhi-de-zheng-shu-ci-fang-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 数值的整数次方
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            long N = n;
            return n < 0 ? 1 / pow(x, -N) : pow(x, N);
        }

        public double pow(double x, long n)
        {
            if (n == 1) return x;
            if (n == 0) return 1;
            if ((n & 1) > 0)
                return x * pow(x, n - 1);
            else
            {
                double res = pow(x, (n >> 1));
                return res * res;
            }
        }
    }
}
