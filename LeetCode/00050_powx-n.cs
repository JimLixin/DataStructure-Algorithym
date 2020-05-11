using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 50. Pow(x, n)
/// 快速幂算法
/// https://leetcode-cn.com/problems/powx-n/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 递归版本
    /// </summary>
    public class _00050_powx_n
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 1.0 / MyPow(x, -n);
            return (n & 1) > 0 ? MyPow(x, n - 1) * x : MyPow(x, (n >> 1)) * MyPow(x, (n >> 1));
        }
    }

    /// <summary>
    /// 迭代版本
    /// </summary>
    public class _00050_powx_n_V2
    {
        public double MyPow(double x, int n)
        {
            double ans = 1;
            long _n = n;
            _n = _n > 0 ? _n : -_n;
            while (_n > 0)
            {
                if ((_n & 1) > 0)
                    ans *= x;
                x *= x;
                _n >>= 1;
            }
            return n > 0 ? ans : 1.0 / ans;
        }
    }
}
